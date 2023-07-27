using DotGod.Spatial.Graphical.Concave.Geometry.Surface;
using System = System;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public abstract class MeshEnvelope : IMesh
{
	protected MeshEnvelope(IMesh mesh) =>
		this.mesh = mesh;

	public override Boolean Equals(System::Object? @object) =>
		mesh.Equals(@object);

	public override Int32 GetHashCode() =>
		mesh.GetHashCode();

	public override System::String? ToString() =>
		mesh.ToString();

	public IEnumerable<ISurface> Surfaces =>
		mesh.Surfaces;
	
	private readonly IMesh mesh;
}