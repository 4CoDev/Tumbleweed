using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;

public sealed class IndexedTool : Any<SurfaceTool>
{
	public IndexedTool(Any<SurfaceTool> origin)
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

	private readonly Any<SurfaceTool> origin;
}