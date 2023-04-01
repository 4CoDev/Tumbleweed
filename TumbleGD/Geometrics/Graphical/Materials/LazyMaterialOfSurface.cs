using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Materials;

public sealed class LazyMaterialOfSurface : ScalarEnvelope<Material>
{
	public LazyMaterialOfSurface(ISurface surface) : base
	(
		new LazyValue<Material>(
			new MaterialOfSurface(surface))
	)
	{
	}
}