using DotGod.Geometry.Graphical.Surfaces;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Materials;

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