using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Concave.With.Polygon.Enumerable;

public sealed class One : Any
{
	public One(SCG::IEnumerable<Spatial.Polygon.Any> polygons) =>
		Polygons = polygons;

	public SCG::IEnumerable<Spatial.Polygon.Any> Polygons { get; }
}