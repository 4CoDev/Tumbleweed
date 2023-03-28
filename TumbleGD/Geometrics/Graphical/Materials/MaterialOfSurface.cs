using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Materials;

public sealed class MaterialOfSurface : ScalarEnvelope<Material>
{
	public MaterialOfSurface(ISurface surface) : base
	(
		new ScalarOfFunction<Material>(
			() => surface.Material)
	)
	{
	}
}