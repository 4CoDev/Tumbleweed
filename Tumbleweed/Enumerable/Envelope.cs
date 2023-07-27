using System.Collections;
using System = System;

namespace Tumbleweed.Enumerable;

public abstract class Envelope : IEnumerable
{
	protected Envelope(IEnumerable enumerable) =>
		this.enumerable = enumerable;

	public IEnumerator GetEnumerator() =>
		enumerable.GetEnumerator();
	
	public override System::Boolean Equals(System::Object? @object) =>
		enumerable.Equals(@object);

	public override Int32 GetHashCode() =>
		enumerable.GetHashCode();

	public override System::String? ToString() =>
		enumerable.ToString();
	
	private readonly IEnumerable enumerable;
}