using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex;

public abstract class Envelope : Any
{
	protected Envelope(Any mesh) =>
		this.mesh = mesh;
	
	public SCG::IEnumerable<Vertex.Any> Vertices =>
		mesh.Vertices;
	
	private readonly Any mesh;
}