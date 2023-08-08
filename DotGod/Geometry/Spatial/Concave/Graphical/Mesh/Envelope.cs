using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;
using System = System;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh;

public abstract class Envelope : Any
{
	protected Envelope(Any mesh) =>
		this.mesh = mesh;

	public override Boolean Equals(System::Object? @object) =>
		mesh.Equals(@object);

	public override Int32 GetHashCode() =>
		mesh.GetHashCode();

	public override System::String? ToString() =>
		mesh.ToString();

	public IEnumerable<Surface::Any> Surfaces =>
		mesh.Surfaces;
	
	private readonly Any mesh;
}