using Mesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex.Mesh;

public abstract class Envelope : Mesh::Any
{
	protected Envelope(Mesh::Any mesh) =>
		this.mesh = mesh;
	
	public SCG::IEnumerable<Vertex::Any> Vertices =>
		mesh.Vertices;
	
	private readonly Mesh::Any mesh;
}