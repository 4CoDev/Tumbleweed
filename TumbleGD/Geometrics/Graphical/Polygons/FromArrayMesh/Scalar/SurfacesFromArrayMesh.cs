using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.FromArrayMesh.
	Scalar;

public sealed class SurfacesFromArrayMesh : IScalar<IEnumerable<ISurface>>
{
	public SurfacesFromArrayMesh(IScalar<ArrayMesh> mesh)
	{
		this.mesh = mesh;
	}
	
	public IEnumerable<ISurface> Value()
	{
		IList<ISurface> surfaces = new List<ISurface>();
		for (int surface = 0; surface < mesh.Value().GetSurfaceCount(); surface++)
		{
			surfaces.Add(new SurfaceWithIndex(mesh, new ScalarOfValue<int>(surface)));
		}
		return surfaces;
	}
	
	private readonly IScalar<ArrayMesh> mesh;
}