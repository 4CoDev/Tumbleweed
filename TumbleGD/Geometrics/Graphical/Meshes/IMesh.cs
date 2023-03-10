using TumbleGD.Geometrics.Graphical.Surfaces;

namespace TumbleGD.Geometrics.Graphical.Meshes;

public interface IMesh
{
	IEnumerable<ISurface> Surfaces { get; }
}