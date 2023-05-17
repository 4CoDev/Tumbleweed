using DotGod.Geometry.Spatial.Graphical.Vertices;

namespace DotGod.Geometry.Spatial.Graphical.Polygons;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}