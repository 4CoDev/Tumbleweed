using DotGod.Geometry.Spatial.Graphical.Surfaces;

namespace DotGod.Geometry.Spatial.Graphical.Meshes;

public abstract class MeshEnvelope : IMesh
{
	protected MeshEnvelope(IMesh mesh) =>
		this.mesh = mesh;

	public override Boolean Equals(Object? @object) =>
		mesh.Equals(@object);

	public override Int32 GetHashCode() =>
		mesh.GetHashCode();

	public override String? ToString() =>
		mesh.ToString();

	public IEnumerable<ISurface> Surfaces =>
		mesh.Surfaces;
	
	private readonly IMesh mesh;
}