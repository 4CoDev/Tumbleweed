using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.OfGodot;

public sealed class IndexedTool : IScalar<SurfaceTool>
{
	public IndexedTool(IScalar<SurfaceTool> origin)
	{
		this.origin = origin;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool indexed = origin.Value;
			indexed.Index();
			return indexed;
		}
	}

	private readonly IScalar<SurfaceTool> origin;
}