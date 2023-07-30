using Tumbleweed.Scalar.Nullable;
using System = System;

namespace Tumbleweed.Storage;

public interface Any
{
	Any<System::Object> ValueWith(System::Object key);
	
	void Add(System::Object key, System::Object value);
	
	void RemoveBy(System::Object key);
}