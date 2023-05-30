using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

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