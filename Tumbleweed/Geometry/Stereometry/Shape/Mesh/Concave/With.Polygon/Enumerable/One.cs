using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Concave.With.Polygon.Enumerable;

public sealed class One : Any
{
	public One(SCG::IEnumerable<Stereometry.Polygon.Any> polygons) =>
		Polygons = polygons;

	public SCG::IEnumerable<Stereometry.Polygon.Any> Polygons { get; }
}