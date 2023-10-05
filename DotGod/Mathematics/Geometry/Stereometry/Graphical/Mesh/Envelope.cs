using System = System;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;

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

	public IEnumerable<Graphical.Surface.Any> Surfaces =>
		mesh.Surfaces;
	
	private readonly Any mesh;
}