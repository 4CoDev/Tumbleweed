using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;
using Tumbleweed.Point.Planar.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV;

public sealed class UVOfVertex : Envelope<Any>
{
	public UVOfVertex(IVertex vertex) : base
	(
		new Result<Any>(() => vertex.UV)
	)
	{
	}
}