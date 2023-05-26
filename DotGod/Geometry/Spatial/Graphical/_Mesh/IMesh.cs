using DotGod.Geometry.Spatial.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

public interface IMesh
{
	IEnumerable<ISurface> Surfaces { get; }
}