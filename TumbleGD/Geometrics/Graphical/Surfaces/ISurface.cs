using Godot;
using TumbleGD.Geometrics.Graphical.Polygons;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

public interface ISurface
{
	IEnumerable<IPolygon> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
