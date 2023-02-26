namespace Tumbleweed.Mutables;

public sealed class MutableEnvelope<T> : IMutable<T>
{
	public MutableEnvelope(IMutable<T> mutable) =>
		this.mutable = mutable;

	public T Value
	{
		get => mutable.Value;
		set => mutable.Value = value;
	}

	private readonly IMutable<T> mutable;
}