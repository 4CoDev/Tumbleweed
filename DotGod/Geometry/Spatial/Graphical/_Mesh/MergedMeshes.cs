using DotGod.Geometry.Spatial.Graphical.Surface;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

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