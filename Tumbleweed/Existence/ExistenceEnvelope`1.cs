using Tumbleweed.Bits;

namespace Tumbleweed.Existence;

public abstract class ExistenceEnvelope<T> : IExistence<T>
{
	protected ExistenceEnvelope(IExistence<T> existence) =>
		this.existence = existence;
	
	public T Value => existence.Value;

	public IBit Exists => existence.Exists;
	
	private readonly IExistence<T> existence;
}