namespace DotGod.Node.Batch.Dimension.Spatial.Spaced;

public abstract class Envelope : Node.Batch.Dimension.Spatial.Spaced.Any
{
	protected Envelope(Node.Batch.Dimension.Spatial.Spaced.Any batch) =>
		this.batch = batch;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Node.Batch.Dimension.Spatial.Unspaced.Any>> Subbatches =>
		batch.Subbatches;

	public ICollection<Entity.Any> Entities =>
		batch.Entities;

	public Space.Any Space =>
		batch.Space;

	private readonly Node.Batch.Dimension.Spatial.Spaced.Any batch;
}