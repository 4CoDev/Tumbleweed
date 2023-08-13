namespace DotGod.Node.Batch.Dimension.Spatial.Spaced;

public interface Any : Node.Batch.Dimension.Spatial.Unspaced.Any
{
	Space.Any Space { get; }
}