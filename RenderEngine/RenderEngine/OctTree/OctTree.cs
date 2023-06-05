using RenderEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenderEngine.OctTree
{
    internal class OctTree
    {
        private const float MinSize = .0005f;

        public BoundingBox Region { get; init; }
        public OctTree[] Children { get; init; }
        public List<IShape> Shapes { get; init; }

        public OctTree(BoundingBox maxRegion, IEnumerable<IShape> shapes)
        {
            Region = maxRegion;
            Shapes = shapes.ToList();
            Children = new OctTree[8];
        }
    }
}
