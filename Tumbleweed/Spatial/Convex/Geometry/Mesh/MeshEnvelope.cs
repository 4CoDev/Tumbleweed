using Tumbleweed.Spatial.Geometry.Vertex;

namespace Tumbleweed.Spatial.Convex.Geometry.Mesh;

public abstract class MeshEnvelope : IMesh
{
	protected MeshEnvelope(IMesh mesh) =>
		this.mesh = mesh;
	
	public IEnumerable<IVertex> Vertices =>
		mesh.Vertices;
	
	private readonly IMesh mesh;
}