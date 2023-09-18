using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex;

public abstract class Envelope : Any
{
	protected Envelope(Any mesh) =>
		this.mesh = mesh;
	
	public SCG::IEnumerable<Vertex::Any> Vertices =>
		mesh.Vertices;
	
	private readonly Any mesh;
}