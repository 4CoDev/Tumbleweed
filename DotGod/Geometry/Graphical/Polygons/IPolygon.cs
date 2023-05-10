using DotGod.Geometry.Graphical.Vertices;

namespace DotGod.Geometry.Graphical.Polygons;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}