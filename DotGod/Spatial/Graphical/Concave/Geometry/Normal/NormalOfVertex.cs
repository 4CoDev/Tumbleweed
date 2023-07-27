using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal;

public sealed class NormalOfVertex : Envelope<Any>
{
	public NormalOfVertex(IVertex vertex) : base
	(
		new Result<Any>(() => vertex.Normal)
	)
	{
	}
}