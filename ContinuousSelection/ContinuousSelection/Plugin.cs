using System;
using System.Collections.Generic;
using System.Linq;

using PEPlugin;

namespace ContinuousSelection
{
    public class Plugin : PEPluginClass
    {
        public override string Name
        {
            get { return "頂点連続面選択"; }
        }

        public override void Run(IPERunArgs args)
        {
            var model = args.Host.Connector.Pmd.GetCurrentState();
            var view = args.Host.Connector.View.PMDView;

            var faces = model.Face.ChunkBy(3);
            var rev = new List<int>[model.Vertex.Count]; // vertex -> face indices
            var map = new List<int>[faces.Count]; // face index -> vertex indices

            for (int i = 0; i < model.Vertex.Count; i++)
                rev[i] = new List<int>();

            for (int i = 0; i < faces.Count; i++)
            {
                map[i] = new List<int>();

                foreach (int v in faces[i])
                {
                    map[i].Add(v);
                    rev[v].Add(i);
                }
            }

            var q = new Queue<int>(); // being searched vertexes
            var visit = new HashSet<int>(); // visited vertex indices
            var visitf = new HashSet<int>(); // visited face indices

            foreach (int selectedv in view.GetSelectedVertexIndices())
            {
                q.Enqueue(selectedv);
                while (q.Count > 0)
                {
                    var current = q.Dequeue();
                    if (visit.Contains(current)) continue;
                    visit.Add(current);

                    foreach (var fi in rev[current])
                    {
                        visitf.Add(fi);
                        foreach (var vi in map[fi])
                        {
                            q.Enqueue(vi);
                        }
                    }
                }
            }

            view.SetSelectedFaceIndices(visitf.SelectMany(p => new int[] { p * 3, p * 3 + 1, p * 3 + 2 }).ToArray());
            view.SetSelectedVertexIndices(visit.ToArray());
            view.UpdateView();
        }
    }

    static class Extensions
    {
        public static List<List<T>> ChunkBy<T>(this IEnumerable<T> list, int size)
        {
            return list.Select((p, i) => new { Index = i, Value = p })
                .GroupBy(p => p.Index / size)
                .Select(p => p.Select(q => q.Value).ToList())
                .ToList();
        }
    }
}
