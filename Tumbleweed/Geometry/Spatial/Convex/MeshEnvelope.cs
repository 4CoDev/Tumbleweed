using Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex;

public abstract class MeshEnvelope : IMesh
{
	protected MeshEnvelope(IMesh mesh) =>
		this.mesh = mesh;
	
	public IEnumerable<IVertex> Vertices =>
		mesh.Vertices;
	
	private readonly IMesh mesh;
}