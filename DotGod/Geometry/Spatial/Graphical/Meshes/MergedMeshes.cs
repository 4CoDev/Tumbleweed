using DotGod.Geometry.Spatial.Graphical.Surfaces;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Spatial.Graphical.Meshes;

public sealed class MergedMeshes : MeshEnvelope
{
	public MergedMeshes(IEnumerable<IMesh> meshes) : base
	(
		new MeshWithSurfaces(
			new EnumerableWithElements<ISurface>(
				new SelectedByExpression<IMesh, IEnumerable<ISurface>>(
					meshes,
					mesh => mesh.Surfaces)))
	)
	{
	}
}