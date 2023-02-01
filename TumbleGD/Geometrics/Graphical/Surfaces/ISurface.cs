using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

public interface ISurface
{
	IEnumerable<IEnumerable<IVertex>> Polygons { get; }
	
	IScalar<Material> Material { get; }
}
