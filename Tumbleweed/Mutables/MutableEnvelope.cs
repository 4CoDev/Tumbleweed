namespace Tumbleweed.Mutables;

public sealed class MutableEnvelope<T> : IMutable<T>
{
	public MutableEnvelope(IMutable<T> mutable) =>
		this.mutable = mutable;

	public override Boolean Equals(Object? @object) =>
		mutable.Equals(@object);

	public override Int32 GetHashCode() =>
		mutable.GetHashCode();

	public override String? ToString() =>
		mutable.ToString();

	public T Value
	{
		get => mutable.Value;
		set => mutable.Value = value;
	}

	private readonly IMutable<T> mutable;
}