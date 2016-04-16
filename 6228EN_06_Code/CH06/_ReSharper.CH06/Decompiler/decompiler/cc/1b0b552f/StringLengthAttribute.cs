// Type: System.ComponentModel.DataAnnotations.StringLengthAttribute
// Assembly: System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ComponentModel.DataAnnotations.dll

using System;
using System.ComponentModel.DataAnnotations.Resources;
using System.Globalization;
using System.Runtime;

namespace System.ComponentModel.DataAnnotations
{
  /// <summary>
  /// Specifies the minimum and maximum length of characters that are allowed in a data field.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
  [__DynamicallyInvokable]
  public class StringLengthAttribute : ValidationAttribute
  {
    /// <summary>
    /// Gets or sets the maximum length of a string.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum length a string.
    /// </returns>
    [__DynamicallyInvokable]
    public int MaximumLength { [__DynamicallyInvokable, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; private set; }

    /// <summary>
    /// Gets or sets the minimum length of a string.
    /// </summary>
    /// 
    /// <returns>
    /// The minimum length of a string.
    /// </returns>
    [__DynamicallyInvokable]
    public int MinimumLength { [__DynamicallyInvokable, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; [__DynamicallyInvokable, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.ComponentModel.DataAnnotations.StringLengthAttribute"/> class by using a specified maximum length.
    /// </summary>
    /// <param name="maximumLength">The maximum length of a string. </param>
    [__DynamicallyInvokable]
    public StringLengthAttribute(int maximumLength)
      : base((Func<string>) (() => DataAnnotationsResources.StringLengthAttribute_ValidationError))
    {
      this.MaximumLength = maximumLength;
    }

    /// <summary>
    /// Determines whether a specified object is valid.
    /// </summary>
    /// 
    /// <returns>
    /// true if the specified object is valid; otherwise, false.
    /// </returns>
    /// <param name="value">The object to validate.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maximumLength"/> is negative.-or-<paramref name="maximumLength"/> is less than <see cref="P:System.ComponentModel.DataAnnotations.StringLengthAttribute.MinimumLength"/>.</exception>
    public override bool IsValid(object value)
    {
      this.EnsureLegalLengths();
      int num = value == null ? 0 : ((string) value).Length;
      if (value == null)
        return true;
      if (num >= this.MinimumLength)
        return num <= this.MaximumLength;
      else
        return false;
    }

    /// <summary>
    /// Applies formatting to a specified error message.
    /// </summary>
    /// 
    /// <returns>
    /// The formatted error message.
    /// </returns>
    /// <param name="name">The name of the field that caused the validation failure.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maximumLength"/> is negative. -or-<paramref name="maximumLength"/> is less than <paramref name="minimumLength"/>.</exception>
    [__DynamicallyInvokable]
    public override string FormatErrorMessage(string name)
    {
      this.EnsureLegalLengths();
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, this.MinimumLength != 0 && !this.CustomErrorMessageSet ? DataAnnotationsResources.StringLengthAttribute_ValidationErrorIncludingMinimum : this.ErrorMessageString, (object) name, (object) this.MaximumLength, (object) this.MinimumLength);
    }

    private void EnsureLegalLengths()
    {
      if (this.MaximumLength < 0)
        throw new InvalidOperationException(DataAnnotationsResources.StringLengthAttribute_InvalidMaxLength);
      if (this.MaximumLength >= this.MinimumLength)
        return;
      throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, DataAnnotationsResources.RangeAttribute_MinGreaterThanMax, new object[2]
      {
        (object) this.MaximumLength,
        (object) this.MinimumLength
      }));
    }
  }
}
