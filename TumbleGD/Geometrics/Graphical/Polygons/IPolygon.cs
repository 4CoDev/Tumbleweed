using TumbleGD.Geometrics.Graphical.Vertices;

namespace TumbleGD.Geometrics.Graphical.Polygons;

public interface IPolygon
{
	IEnumerable<IVertex> Vertices { get; }
}