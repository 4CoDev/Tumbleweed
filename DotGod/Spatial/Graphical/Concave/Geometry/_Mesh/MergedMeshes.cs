using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using Tumbleweed.Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class MergedMeshes : MeshEnvelope
{
	public MergedMeshes(IEnumerable<IMesh> meshes) : base
	(
		new MeshWithSurfaces(
			new Concatenated<ISurface>(
				new Selected<IMesh, IEnumerable<ISurface>>(
					meshes,
					mesh => mesh.Surfaces)))
	)
	{
	}
}