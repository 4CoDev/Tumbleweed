using DotGod.Geometrics.Graphical.Vertices;

namespace DotGod.Geometrics.Graphical.Polygons;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}