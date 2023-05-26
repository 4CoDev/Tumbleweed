using DotGod.Geometry.Spatial.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

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