using SCG = System.Collections.Generic;
using Polygon = Tumbleweed.Geometry.Spatial.Concave.Polygon;

namespace Tumbleweed.Geometry.Spatial.Concave.Mesh.With.Polygon.Enumerable;

public sealed class One : Any
{
	public One(SCG::IEnumerable<Polygon::Any> polygons) =>
		Polygons = polygons;

	public SCG::IEnumerable<Polygon::Any> Polygons { get; }
}