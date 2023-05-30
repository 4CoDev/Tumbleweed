using DotGod.Spatial.Graphical.Concave.Geometry.Surface;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

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