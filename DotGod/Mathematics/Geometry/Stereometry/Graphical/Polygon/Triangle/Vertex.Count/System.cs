using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Triangle.Vertex.Count;

public sealed class System : Envelope<Int32>
{
	public System() : base
	(
		new One<Int32>(3)
	)
	{
	}
}