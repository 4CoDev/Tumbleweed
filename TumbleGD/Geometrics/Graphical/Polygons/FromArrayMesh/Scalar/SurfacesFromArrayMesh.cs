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

	public IEnumerable<ISurface> Value
	{
		get
		{
			IList<ISurface> surfaces = new List<ISurface>();
			for (Int32 surface = 0; surface < mesh.Value.GetSurfaceCount(); surface++)
			{
				surfaces.Add(new SurfaceWithIndex(mesh, new ScalarOfValue<Int32>(surface)));
			}
			return surfaces;
		}
	}

	private readonly IScalar<ArrayMesh> mesh;
}