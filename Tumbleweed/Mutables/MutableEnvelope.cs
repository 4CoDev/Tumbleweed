namespace Tumbleweed.Mutables;

public abstract class MutableEnvelope<T> : IMutable<T>
{
	protected MutableEnvelope(IMutable<T> mutable) =>
		this.mutable = mutable;

	public override Boolean Equals(Object? @object) =>
		mutable.Equals(@object);

	public override Int32 GetHashCode() =>
		mutable.GetHashCode();

	public override String? ToString() =>
		mutable.ToString();

	public T Variable
	{
		get => mutable.Variable;
		set => mutable.Variable = value;
	}

	private readonly IMutable<T> mutable;
}