// Type: System.Windows.FrameworkElement
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\PresentationFramework.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace System.Windows
{
  /// <summary>
  /// Provides a WPF framework-level set of properties, events, and methods for Windows Presentation Foundation (WPF) elements. This class represents the provided WPF framework-level implementation that is built on the WPF core-level APIs that are defined by <see cref="T:System.Windows.UIElement"/>.
  /// </summary>
  [StyleTypedProperty(Property = "FocusVisualStyle", StyleTargetType = typeof (Control))]
  [UsableDuringInitialization(true)]
  [RuntimeNameProperty("Name")]
  [XmlLangProperty("Language")]
  public class FrameworkElement : UIElement, IFrameworkInputElement, IInputElement, ISupportInitialize, IHaveResources, IQueryAmbient
  {
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Style"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.Style"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty StyleProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.OverridesDefaultStyle"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.OverridesDefaultStyle"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty OverridesDefaultStyleProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.UseLayoutRounding"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.UseLayoutRounding"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty UseLayoutRoundingProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.DefaultStyleKey"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.DefaultStyleKey"/> dependency property identifier.
    /// </returns>
    protected internal static readonly DependencyProperty DefaultStyleKeyProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.DataContext"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.DataContext"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty DataContextProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.BindingGroup"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.BindingGroup"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty BindingGroupProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Language"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.Language"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty LanguageProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Name"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.Name"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty NameProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Tag"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.Tag"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty TagProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.InputScope"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.InputScope"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty InputScopeProperty;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.RequestBringIntoView"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.RequestBringIntoView"/> routed event.Routed event identifiers are created when routed events are registered. These identifiers contain an identifying name, owner type, handler type, routing strategy, and utility method for adding owners for the event. You can use these identifiers to add class handlers. For more information about registering routed events, see <see cref="M:System.Windows.EventManager.RegisterRoutedEvent(System.String,System.Windows.RoutingStrategy,System.Type,System.Type)"/>. For more information about using routed event identifiers to add class handlers, see <see cref="M:System.Windows.EventManager.RegisterClassHandler(System.Type,System.Windows.RoutedEvent,System.Delegate)"/>.
    /// </returns>
    public static readonly RoutedEvent RequestBringIntoViewEvent;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.SizeChanged"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.RequestBringIntoView"/> routed event.
    /// </returns>
    public static readonly RoutedEvent SizeChangedEvent;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.ActualWidth"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.ActualWidth"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty ActualWidthProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.ActualHeight"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.ActualHeight"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty ActualHeightProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.LayoutTransform"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.LayoutTransform"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty LayoutTransformProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Width"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.Width"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty WidthProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.MinWidth"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.MinWidth"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty MinWidthProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.MaxWidth"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.MaxWidth"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty MaxWidthProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Height"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.Height"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty HeightProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.MinHeight"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.MinHeight"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty MinHeightProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.MaxHeight"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.MaxHeight"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty MaxHeightProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.FlowDirection"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.FlowDirection"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty FlowDirectionProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Margin"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.Margin"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty MarginProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.HorizontalAlignment"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.HorizontalAlignment"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty HorizontalAlignmentProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.VerticalAlignment"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.VerticalAlignment"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty VerticalAlignmentProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.FocusVisualStyle"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.FocusVisualStyle"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty FocusVisualStyleProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.Cursor"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.Cursor"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty CursorProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.ForceCursor"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="P:System.Windows.FrameworkElement.ForceCursor"/> dependency property.
    /// </returns>
    public static readonly DependencyProperty ForceCursorProperty;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.Loaded"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.Loaded"/> routed event.
    /// </returns>
    public static readonly RoutedEvent LoadedEvent;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.Unloaded"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.Unloaded"/> routed event.
    /// </returns>
    public static readonly RoutedEvent UnloadedEvent;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.ToolTip"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.ToolTip"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty ToolTipProperty;
    /// <summary>
    /// Identifies the <see cref="P:System.Windows.FrameworkElement.ContextMenu"/> dependency property.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="P:System.Windows.FrameworkElement.ContextMenu"/> dependency property identifier.
    /// </returns>
    public static readonly DependencyProperty ContextMenuProperty;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.ToolTipOpening"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.ToolTipOpening"/> routed event.
    /// </returns>
    public static readonly RoutedEvent ToolTipOpeningEvent;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.ToolTipClosing"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.ToolTipClosing"/> routed event.
    /// </returns>
    public static readonly RoutedEvent ToolTipClosingEvent;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.ContextMenuOpening"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.ContextMenuClosing"/> routed event.
    /// </returns>
    public static readonly RoutedEvent ContextMenuOpeningEvent;
    /// <summary>
    /// Identifies the <see cref="E:System.Windows.FrameworkElement.ContextMenuClosing"/> routed event.
    /// </summary>
    /// 
    /// <returns>
    /// The identifier for the <see cref="E:System.Windows.FrameworkElement.ContextMenuClosing"/> routed event.
    /// </returns>
    public static readonly RoutedEvent ContextMenuClosingEvent;
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Windows.FrameworkElement"/> class.
    /// </summary>
    public FrameworkElement();
    /// <summary>
    /// Returns whether serialization processes should serialize the contents of the <see cref="P:System.Windows.FrameworkElement.Style"/> property.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.Windows.FrameworkElement.Style"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStyle();
    /// <summary>
    /// Invoked when the style in use on this element changes, which will invalidate the layout.
    /// </summary>
    /// <param name="oldStyle">The old style.</param><param name="newStyle">The new style.</param>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    protected internal virtual void OnStyleChanged(Style oldStyle, Style newStyle);
    /// <summary>
    /// Supports incremental layout implementations in specialized subclasses of <see cref="T:System.Windows.FrameworkElement"/>. <see cref="M:System.Windows.FrameworkElement.ParentLayoutInvalidated(System.Windows.UIElement)"/>  is invoked when a child element has invalidated a property that is marked in metadata as affecting the parent's measure or arrange passes during layout.
    /// </summary>
    /// <param name="child">The child element reporting the change.</param>
    protected internal virtual void ParentLayoutInvalidated(UIElement child);
    /// <summary>
    /// Builds the current template's visual tree if necessary, and returns a value that indicates whether the visual tree was rebuilt by this call.
    /// </summary>
    /// 
    /// <returns>
    /// true if visuals were added to the tree; returns false otherwise.
    /// </returns>
    public bool ApplyTemplate();
    /// <summary>
    /// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
    /// </summary>
    public virtual void OnApplyTemplate();
    /// <summary>
    /// Begins the sequence of actions that are contained in the provided storyboard.
    /// </summary>
    /// <param name="storyboard">The storyboard to begin.</param>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void BeginStoryboard(Storyboard storyboard);
    /// <summary>
    /// Begins the sequence of actions contained in the provided storyboard, with options specified for what should happen if the property is already animated.
    /// </summary>
    /// <param name="storyboard">The storyboard to begin.</param><param name="handoffBehavior">A value of the enumeration that describes behavior to use if a property described in the storyboard is already animated.</param>
    [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
    public void BeginStoryboard(Storyboard storyboard, HandoffBehavior handoffBehavior);
    /// <summary>
    /// Begins the sequence of actions contained in the provided storyboard, with specified state for control of the animation after it is started.
    /// </summary>
    /// <param name="storyboard">The storyboard to begin. </param><param name="handoffBehavior">A value of the enumeration that describes behavior to use if a property described in the storyboard is already animated.</param><param name="isControllable">Declares whether the animation is controllable (can be paused) after it is started.</param>
    public void BeginStoryboard(Storyboard storyboard, HandoffBehavior handoffBehavior, bool isControllable);
    /// <summary>
    /// Returns whether serialization processes should serialize the contents of the <see cref="P:System.Windows.FrameworkElement.Triggers"/> property.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.Windows.FrameworkElement.Triggers"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTriggers();
    /// <summary>
    /// Overrides <see cref="M:System.Windows.Media.Visual.GetVisualChild(System.Int32)"/>, and returns a child at the specified index from a collection of child elements.
    /// </summary>
    /// 
    /// <returns>
    /// The requested child element. This should not return null; if the provided index is out of range, an exception is thrown.
    /// </returns>
    /// <param name="index">The zero-based index of the requested child element in the collection.</param>
    protected override Visual GetVisualChild(int index);
    /// <summary>
    /// For a description of this member, see the <see cref="M:System.Windows.Markup.IQueryAmbient.IsAmbientPropertyAvailable(System.String)"/> method.
    /// </summary>
    /// 
    /// <returns>
    /// true if <paramref name="propertyName"/> is available; otherwise, false.
    /// </returns>
    /// <param name="propertyName">The name of the requested ambient property.</param>
    bool IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);
    /// <summary>
    /// Returns whether serialization processes should serialize the contents of the <see cref="P:System.Windows.FrameworkElement.Resources"/> property.
    /// </summary>
    /// 
    /// <returns>
    /// true if the <see cref="P:System.Windows.FrameworkElement.Resources"/> property value should be serialized; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeResources();
    /// <summary>
    /// Returns the named element in the visual tree of an instantiated <see cref="T:System.Windows.Controls.ControlTemplate"/>.
    /// </summary>
    /// 
    /// <returns>
    /// The requested element. May be null if no element of the requested name exists.
    /// </returns>
    /// <param name="childName">Name of the child to find.</param>
    protected internal DependencyObject GetTemplateChild(string childName);
    /// <summary>
    /// Searches for a resource with the specified key, and throws an exception if the requested resource is not found.
    /// </summary>
    /// 
    /// <returns>
    /// The requested resource. If no resource with the provided key was found, an exception is thrown. An <see cref="F:System.Windows.DependencyProperty.UnsetValue"/> value might also be returned in the exception case.
    /// </returns>
    /// <param name="resourceKey">The key identifier for the requested resource.</param><exception cref="T:System.Windows.ResourceReferenceKeyNotFoundException"><paramref name="resourceKey"/> was not found and an event handler does not exist for the <see cref="E:System.Windows.Threading.Dispatcher.UnhandledException"/> event.-or-<paramref name="resourceKey"/> was not found and the <see cref="P:System.Windows.Threading.DispatcherUnhandledExceptionEventArgs.Handled"/> property is false in the <see cref="E:System.Windows.Threading.Dispatcher.UnhandledException"/> event.</exception><exception cref="T:System.ArgumentNullException"><paramref name="resourceKey"/> is null.</exception>
    public object FindResource(object resourceKey);
    /// <summary>
    /// Searches for a resource with the specified key, and returns that resource if found.
    /// </summary>
    /// 
    /// <returns>
    /// The found resource, or null if no resource with the provided <paramref name="key"/> is found.
    /// </returns>
    /// <param name="resourceKey">The key identifier of the resource to be found.</param>
    public object TryFindResource(object resourceKey);
    /// <summary>
    /// Searches for a resource with the specified name and sets up a resource reference to it for the specified property.
    /// </summary>
    /// <param name="dp">The property to which the resource is bound.</param><param name="name">The name of the resource.</param>
    public void SetResourceReference(DependencyProperty dp, object name);
    /// <summary>
    /// Invoked whenever the effective value of any dependency property on this <see cref="T:System.Windows.FrameworkElement"/> has been updated. The specific dependency property that changed is reported in the arguments parameter. Overrides <see cref="M:System.Windows.DependencyObject.OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs)"/>.
    /// </summary>
    /// <param name="e">The event data that describes the property that changed, as well as old and new values.</param>
    protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
    /// <summary>
    /// Invoked when the parent of this element in the visual tree is changed. Overrides <see cref="M:System.Windows.UIElement.OnVisualParentChanged(System.Windows.DependencyObject)"/>.
    /// </summary>
    /// <param name="oldParent">The old parent element. May be null to indicate that the element did not have a visual parent previously.</param>
    protected internal override void OnVisualParentChanged(DependencyObject oldParent);
    /// <summary>
    /// Returns the <see cref="T:System.Windows.Data.BindingExpression"/> that represents the binding on the specified property.
    /// </summary>
    /// 
    /// <returns>
    /// A <see cref="T:System.Windows.Data.BindingExpression"/> if the target property has an active binding; otherwise, returns null.
    /// </returns>
    /// <param name="dp">The target <see cref="T:System.Windows.DependencyProperty"/> to get the binding from.</param>
    public BindingExpression GetBindingExpression(DependencyProperty dp);
    /// <summary>
    /// Attaches a binding to this element, based on the provided binding object.
    /// </summary>
    /// 
    /// <returns>
    /// Records the conditions of the binding. This return value can be useful for error checking.
    /// </returns>
    /// <param name="dp">Identifies the property where the binding should be established.</param><param name="binding">Represents the specifics of the data binding.</param>
    public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding);
    /// <summary>
    /// Attaches a binding to this element, based on the provided source property name as a path qualification to the data source.
    /// </summary>
    /// 
    /// <returns>
    /// Records the conditions of the binding. This return value can be useful for error checking.
    /// </returns>
    /// <param name="dp">Identifies the destination property where the binding should be established.</param><param name="path">The source property name or the path to the property used for the binding.</param>
    public BindingExpression SetBinding(DependencyProperty dp, string path);
    /// <summary>
    /// Returns an alternative logical parent for this element if there is no visual parent.
    /// </summary>
    /// 
    /// <returns>
    /// Returns something other than null whenever a WPF framework-level implementation of this method has a non-visual parent connection.
    /// </returns>
    protected internal override DependencyObject GetUIParentCore();
    /// <summary>
    /// Attempts to bring this element into view, within any scrollable regions it is contained within.
    /// </summary>
    public void BringIntoView();
    /// <summary>
    /// Attempts to bring the provided region size of this element into view, within any scrollable regions it is contained within.
    /// </summary>
    /// <param name="targetRectangle">Specified size of the element that should also be brought into view. </param>
    public void BringIntoView(Rect targetRectangle);
    /// <summary>
    /// Gets the value of the <see cref="P:System.Windows.FrameworkElement.FlowDirection"/> attached property for the specified <see cref="T:System.Windows.DependencyObject"/>.
    /// </summary>
    /// 
    /// <returns>
    /// The requested flow direction, as a value of the enumeration.
    /// </returns>
    /// <param name="element">The element to return a <see cref="P:System.Windows.FrameworkElement.FlowDirection"/> for.</param>
    public static FlowDirection GetFlowDirection(DependencyObject element);
    /// <summary>
    /// Sets the value of the <see cref="P:System.Windows.FrameworkElement.FlowDirection"/> attached property for the provided element.
    /// </summary>
    /// <param name="element">The element that specifies a flow direction.</param><param name="value">A value of the enumeration, specifying the direction.</param>
    public static void SetFlowDirection(DependencyObject element, FlowDirection value);
    /// <summary>
    /// Implements basic measure-pass layout system behavior for <see cref="T:System.Windows.FrameworkElement"/>.
    /// </summary>
    /// 
    /// <returns>
    /// The desired size of this element in layout.
    /// </returns>
    /// <param name="availableSize">The available size that the parent element can give to the child elements.</param>
    protected override sealed Size MeasureCore(Size availableSize);
    /// <summary>
    /// Implements <see cref="M:System.Windows.UIElement.ArrangeCore(System.Windows.Rect)"/> (defined as virtual in <see cref="T:System.Windows.UIElement"/>) and seals the implementation.
    /// </summary>
    /// <param name="finalRect">The final area within the parent that this element should use to arrange itself and its children.</param>
    protected override sealed void ArrangeCore(Rect finalRect);
    /// <summary>
    /// Raises the <see cref="E:System.Windows.FrameworkElement.SizeChanged"/> event, using the specified information as part of the eventual event data.
    /// </summary>
    /// <param name="sizeInfo">Details of the old and new size involved in the change.</param>
    protected internal override void OnRenderSizeChanged(SizeChangedInfo sizeInfo);
    /// <summary>
    /// Returns a geometry for a clipping mask. The mask applies if the layout system attempts to arrange an element that is larger than the available display space.
    /// </summary>
    /// 
    /// <returns>
    /// The clipping geometry.
    /// </returns>
    /// <param name="layoutSlotSize">The size of the part of the element that does visual presentation. </param>
    protected override Geometry GetLayoutClip(Size layoutSlotSize);
    /// <summary>
    /// When overridden in a derived class, measures the size in layout required for child elements and determines a size for the <see cref="T:System.Windows.FrameworkElement"/>-derived class.
    /// </summary>
    /// 
    /// <returns>
    /// The size that this element determines it needs during layout, based on its calculations of child element sizes.
    /// </returns>
    /// <param name="availableSize">The available size that this element can give to child elements. Infinity can be specified as a value to indicate that the element will size to whatever content is available.</param>
    protected virtual Size MeasureOverride(Size availableSize);
    /// <summary>
    /// When overridden in a derived class, positions child elements and determines a size for a <see cref="T:System.Windows.FrameworkElement"/> derived class.
    /// </summary>
    /// 
    /// <returns>
    /// The actual size used.
    /// </returns>
    /// <param name="finalSize">The final area within the parent that this element should use to arrange itself and its children.</param>
    protected virtual Size ArrangeOverride(Size finalSize);
    /// <summary>
    /// Moves the keyboard focus away from this element and to another element in a provided traversal direction.
    /// </summary>
    /// 
    /// <returns>
    /// Returns true if focus is moved successfully; false if the target element in direction as specified does not exist or could not be keyboard focused.
    /// </returns>
    /// <param name="request">The direction that focus is to be moved, as a value of the enumeration.</param>
    public override sealed bool MoveFocus(TraversalRequest request);
    /// <summary>
    /// Determines the next element that would receive focus relative to this element for a provided focus movement direction, but does not actually move the focus.
    /// </summary>
    /// 
    /// <returns>
    /// The next element that focus would move to if focus were actually traversed. May return null if focus cannot be moved relative to this element for the provided direction.
    /// </returns>
    /// <param name="direction">The direction for which a prospective focus change should be determined.</param><exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Specified one of the following directions in the <see cref="T:System.Windows.Input.TraversalRequest"/>: <see cref="F:System.Windows.Input.FocusNavigationDirection.Next"/>, <see cref="F:System.Windows.Input.FocusNavigationDirection.Previous"/>, <see cref="F:System.Windows.Input.FocusNavigationDirection.First"/>, <see cref="F:System.Windows.Input.FocusNavigationDirection.Last"/>. These directions are not legal for <see cref="M:System.Windows.FrameworkElement.PredictFocus(System.Windows.Input.FocusNavigationDirection)"/> (but they are legal for <see cref="M:System.Windows.FrameworkElement.MoveFocus(System.Windows.Input.TraversalRequest)"/>). </exception>
    public override sealed DependencyObject PredictFocus(FocusNavigationDirection direction);
    /// <summary>
    /// Invoked whenever an unhandled <see cref="E:System.Windows.UIElement.GotFocus"/> event reaches this element in its route.
    /// </summary>
    /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
    protected override void OnGotFocus(RoutedEventArgs e);
    /// <summary>
    /// Starts the initialization process for this element.
    /// </summary>
    public virtual void BeginInit();
    /// <summary>
    /// Indicates that the initialization process for the element is complete.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException"><see cref="M:System.Windows.FrameworkElement.EndInit"/> was called without <see cref="M:System.Windows.FrameworkElement.BeginInit"/> having previously been called on the element.</exception>
    public virtual void EndInit();
    /// <summary>
    /// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
    /// </summary>
    /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
    protected virtual void OnInitialized(EventArgs e);
    /// <summary>
    /// Invoked whenever the <see cref="E:System.Windows.FrameworkElement.ToolTipOpening"/> routed event reaches this class in its route. Implement this method to add class handling for this event.
    /// </summary>
    /// <param name="e">Provides data about the event.</param>
    protected virtual void OnToolTipOpening(ToolTipEventArgs e);
    /// <summary>
    /// Invoked whenever an unhandled <see cref="E:System.Windows.FrameworkElement.ToolTipClosing"/> routed event reaches this class in its route. Implement this method to add class handling for this event.
    /// </summary>
    /// <param name="e">Provides data about the event.</param>
    protected virtual void OnToolTipClosing(ToolTipEventArgs e);
    /// <summary>
    /// Invoked whenever an unhandled <see cref="E:System.Windows.FrameworkElement.ContextMenuOpening"/> routed event reaches this class in its route. Implement this method to add class handling for this event.
    /// </summary>
    /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
    protected virtual void OnContextMenuOpening(ContextMenuEventArgs e);
    /// <summary>
    /// Invoked whenever an unhandled <see cref="E:System.Windows.FrameworkElement.ContextMenuClosing"/> routed event reaches this class in its route. Implement this method to add class handling for this event.
    /// </summary>
    /// <param name="e">Provides data about the event.</param>
    protected virtual void OnContextMenuClosing(ContextMenuEventArgs e);
    /// <summary>
    /// Provides an accessor that simplifies access to the <see cref="T:System.Windows.NameScope"/> registration method.
    /// </summary>
    /// <param name="name">Name to use for the specified name-object mapping.</param><param name="scopedElement">Object for the mapping.</param>
    public void RegisterName(string name, object scopedElement);
    /// <summary>
    /// Simplifies access to the <see cref="T:System.Windows.NameScope"/> de-registration method.
    /// </summary>
    /// <param name="name">Name of the name-object pair to remove from the current scope.</param>
    public void UnregisterName(string name);
    /// <summary>
    /// Finds an element that has the provided identifier name.
    /// </summary>
    /// 
    /// <returns>
    /// The requested element. This can be null if no matching element was found.
    /// </returns>
    /// <param name="name">The name of the requested element.</param>
    public object FindName(string name);
    /// <summary>
    /// Reapplies the default style to the current <see cref="T:System.Windows.FrameworkElement"/>.
    /// </summary>
    public void UpdateDefaultStyle();
    /// <summary>
    /// Adds the provided object to the logical tree of this element.
    /// </summary>
    /// <param name="child">Child element to be added.</param>
    protected internal void AddLogicalChild(object child);
    /// <summary>
    /// Removes the provided object from this element's logical tree. <see cref="T:System.Windows.FrameworkElement"/> updates the affected logical tree parent pointers to keep in sync with this deletion.
    /// </summary>
    /// <param name="child">The element to remove.</param>
    protected internal void RemoveLogicalChild(object child);
    /// <summary>
    /// Gets or sets the style used by this element when it is rendered.
    /// </summary>
    /// 
    /// <returns>
    /// The applied, nondefault style for the element, if present. Otherwise, null. The default for a default-constructed <see cref="T:System.Windows.FrameworkElement"/> is null.
    /// </returns>
    public Style Style { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    /// <summary>
    /// Gets or sets a value that indicates whether this element incorporates style properties from theme styles.
    /// </summary>
    /// 
    /// <returns>
    /// true if this element does not use theme style properties; all style-originating properties come from local application styles, and theme style properties do not apply. false if application styles apply first, and then theme styles apply for properties that were not specifically set in application styles. The default is false.
    /// </returns>
    public bool OverridesDefaultStyle { get; set; }
    /// <summary>
    /// Gets or sets a value that indicates whether layout rounding should be applied to this element's size and position during layout.
    /// </summary>
    /// 
    /// <returns>
    /// true if layout rounding is applied; otherwise, false. The default is false.
    /// </returns>
    public bool UseLayoutRounding { get; set; }
    /// <summary>
    /// Gets or sets the key to use to reference the style for this control, when theme styles are used or defined.
    /// </summary>
    /// 
    /// <returns>
    /// The style key. To work correctly as part of theme style lookup, this value is expected to be the <see cref="T:System.Type"/> of the control being styled.
    /// </returns>
    protected internal object DefaultStyleKey { get; set; }
    /// <summary>
    /// Gets the collection of triggers established directly on this element, or in child elements.
    /// </summary>
    /// 
    /// <returns>
    /// A strongly typed collection of <see cref="T:System.Windows.Trigger"/> objects.
    /// </returns>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public TriggerCollection Triggers { get; }
    /// <summary>
    /// Gets a reference to the template parent of this element. This property is not relevant if the element was not created through a template.
    /// </summary>
    /// 
    /// <returns>
    /// The element whose <see cref="T:System.Windows.FrameworkTemplate"/> <see cref="P:System.Windows.FrameworkTemplate.VisualTree"/> caused this element to be created. This value is frequently null; see Remarks.
    /// </returns>
    public DependencyObject TemplatedParent { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets the number of visual child elements within this element.
    /// </summary>
    /// 
    /// <returns>
    /// The number of visual child elements for this element.
    /// </returns>
    protected override int VisualChildrenCount { get; }
    /// <summary>
    /// Gets or sets the locally-defined resource dictionary.
    /// </summary>
    /// 
    /// <returns>
    /// The current locally-defined dictionary of resources, where each resource can be accessed by key.
    /// </returns>
    [Ambient]
    public ResourceDictionary Resources { get; set; }
    /// <summary>
    /// Gets or sets the scope limits for property value inheritance, resource key lookup, and RelativeSource FindAncestor lookup.
    /// </summary>
    /// 
    /// <returns>
    /// A value of the enumeration. The default is <see cref="F:System.Windows.InheritanceBehavior.Default"/>.
    /// </returns>
    protected internal InheritanceBehavior InheritanceBehavior { get; set; }
    /// <summary>
    /// Gets or sets the data context for an element when it participates in data binding.
    /// </summary>
    /// 
    /// <returns>
    /// The object to use as data context.
    /// </returns>
    [Localizability(LocalizationCategory.NeverLocalize)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object DataContext { get; set; }
    /// <summary>
    /// Gets or sets the <see cref="T:System.Windows.Data.BindingGroup"/> that is used for the element.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Windows.Data.BindingGroup"/> that is used for the element.
    /// </returns>
    [Localizability(LocalizationCategory.NeverLocalize)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public BindingGroup BindingGroup { get; set; }
    /// <summary>
    /// Gets or sets localization/globalization language information that applies to an element.
    /// </summary>
    /// 
    /// <returns>
    /// The language information for this element. The default value is an <see cref="T:System.Windows.Markup.XmlLanguage"/> with its <see cref="P:System.Windows.Markup.XmlLanguage.IetfLanguageTag"/> value set to the string "en-US".
    /// </returns>
    public XmlLanguage Language { get; set; }
    /// <summary>
    /// Gets or sets the identifying name of the element. The name provides a reference so that code-behind, such as event handler code, can refer to a markup element after it is constructed during processing by a XAML processor.
    /// </summary>
    /// 
    /// <returns>
    /// The name of the element. The default is an empty string.
    /// </returns>
    [MergableProperty(false)]
    [Localizability(LocalizationCategory.NeverLocalize)]
    [DesignerSerializationOptions(DesignerSerializationOptions.SerializeAsAttribute)]
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets an arbitrary object value that can be used to store custom information about this element.
    /// </summary>
    /// 
    /// <returns>
    /// The intended value. This property has no default value.
    /// </returns>
    [Localizability(LocalizationCategory.NeverLocalize)]
    public object Tag { get; set; }
    /// <summary>
    /// Gets or sets the context for input used by this <see cref="T:System.Windows.FrameworkElement"/>.
    /// </summary>
    /// 
    /// <returns>
    /// The input scope, which modifies how input from alternative input methods is interpreted. The default value is null (which results in a default handling of commands).
    /// </returns>
    public InputScope InputScope { get; set; }
    /// <summary>
    /// Gets the rendered width of this element.
    /// </summary>
    /// 
    /// <returns>
    /// The element's width, as a value in device-independent units (1/96th inch per unit). The default value is 0 (zero).
    /// </returns>
    public double ActualWidth { get; }
    /// <summary>
    /// Gets the rendered height of this element.
    /// </summary>
    /// 
    /// <returns>
    /// The element's height, as a value in device-independent units (1/96th inch per unit). The default value is 0 (zero).
    /// </returns>
    public double ActualHeight { get; }
    /// <summary>
    /// Gets or sets a graphics transformation that should apply to this element when  layout is performed.
    /// </summary>
    /// 
    /// <returns>
    /// The transform this element should use. The default is <see cref="P:System.Windows.Media.Transform.Identity"/>.
    /// </returns>
    public Transform LayoutTransform { get; set; }
    /// <summary>
    /// Gets or sets the width of the element.
    /// </summary>
    /// 
    /// <returns>
    /// The width of the element, in device-independent units (1/96th inch per unit). The default value is <see cref="F:System.Double.NaN"/>. This value must be equal to or greater than 0.0. See Remarks for upper bound information.
    /// </returns>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    [TypeConverter(typeof (LengthConverter))]
    public double Width { get; set; }
    /// <summary>
    /// Gets or sets the minimum width constraint of the element.
    /// </summary>
    /// 
    /// <returns>
    /// The minimum width of the element, in device-independent units (1/96th inch per unit). The default value is 0.0. This value can be any value equal to or greater than 0.0. However, <see cref="F:System.Double.PositiveInfinity"/> is not valid, nor is <see cref="F:System.Double.NaN"/>.
    /// </returns>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    [TypeConverter(typeof (LengthConverter))]
    public double MinWidth { get; set; }
    /// <summary>
    /// Gets or sets the maximum width constraint of the element.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum width of the element, in device-independent units (1/96th inch per unit). The default value is <see cref="F:System.Double.PositiveInfinity"/>. This value can be any value equal to or greater than 0.0. <see cref="F:System.Double.PositiveInfinity"/> is also valid.
    /// </returns>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    [TypeConverter(typeof (LengthConverter))]
    public double MaxWidth { get; set; }
    /// <summary>
    /// Gets or sets the suggested height of the element.
    /// </summary>
    /// 
    /// <returns>
    /// The height of the element, in device-independent units (1/96th inch per unit). The default value is <see cref="F:System.Double.NaN"/>. This value must be equal to or greater than 0.0. See Remarks for upper bound information.
    /// </returns>
    [TypeConverter(typeof (LengthConverter))]
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    public double Height { get; set; }
    /// <summary>
    /// Gets or sets the minimum height constraint of the element.
    /// </summary>
    /// 
    /// <returns>
    /// The minimum height of the element, in device-independent units (1/96th inch per unit). The default value is 0.0. This value can be any value equal to or greater than 0.0. However, <see cref="F:System.Double.PositiveInfinity"/> is NOT valid, nor is <see cref="F:System.Double.NaN"/>.
    /// </returns>
    [TypeConverter(typeof (LengthConverter))]
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    public double MinHeight { get; set; }
    /// <summary>
    /// Gets or sets the maximum height constraint of the element.
    /// </summary>
    /// 
    /// <returns>
    /// The maximum height of the element, in device-independent units (1/96th inch per unit). The default value is <see cref="F:System.Double.PositiveInfinity"/>. This value can be any value equal to or greater than 0.0. <see cref="F:System.Double.PositiveInfinity"/> is also valid.
    /// </returns>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    [TypeConverter(typeof (LengthConverter))]
    public double MaxHeight { get; set; }
    /// <summary>
    /// Gets or sets the direction that text and other user interface (UI) elements flow within any parent element that controls their layout.
    /// </summary>
    /// 
    /// <returns>
    /// The direction that text and other UI elements flow within their parent element, as a value of the enumeration. The default value is <see cref="F:System.Windows.FlowDirection.LeftToRight"/>.
    /// </returns>
    [Localizability(LocalizationCategory.None)]
    public FlowDirection FlowDirection { get; set; }
    /// <summary>
    /// Gets or sets the outer margin of an element.
    /// </summary>
    /// 
    /// <returns>
    /// Provides margin values for the element. The default value is a <see cref="T:System.Windows.Thickness"/> with all properties equal to 0 (zero).
    /// </returns>
    public Thickness Margin { get; set; }
    /// <summary>
    /// Gets or sets the horizontal alignment characteristics applied to this element when it is composed within a parent element, such as a panel or items control.
    /// </summary>
    /// 
    /// <returns>
    /// A horizontal alignment setting, as a value of the enumeration. The default is <see cref="F:System.Windows.HorizontalAlignment.Stretch"/>.
    /// </returns>
    public HorizontalAlignment HorizontalAlignment { get; set; }
    /// <summary>
    /// Gets or sets the vertical alignment characteristics applied to this element when it is composed within a parent element such as a panel or items control.
    /// </summary>
    /// 
    /// <returns>
    /// A vertical alignment setting. The default is <see cref="F:System.Windows.VerticalAlignment.Stretch"/>.
    /// </returns>
    public VerticalAlignment VerticalAlignment { get; set; }
    /// <summary>
    /// Gets or sets a property that enables customization of appearance, effects, or other style characteristics that will apply to this element when it captures keyboard focus.
    /// </summary>
    /// 
    /// <returns>
    /// The desired style to apply on focus. The default value as declared in the dependency property is an empty static <see cref="T:System.Windows.Style"/>. However, the effective value at run time is often (but not always) a style as supplied by theme support for controls.
    /// </returns>
    public Style FocusVisualStyle { get; set; }
    /// <summary>
    /// Gets or sets the cursor that displays when the mouse pointer is over this element.
    /// </summary>
    /// 
    /// <returns>
    /// The cursor to display. The default value is defined as null per this dependency property. However, the practical default at run time will come from a variety of factors.
    /// </returns>
    public Cursor Cursor { get; set; }
    /// <summary>
    /// Gets or sets a value that indicates whether this <see cref="T:System.Windows.FrameworkElement"/> should force the user interface (UI) to render the cursor as declared by the <see cref="P:System.Windows.FrameworkElement.Cursor"/> property.
    /// </summary>
    /// 
    /// <returns>
    /// true if cursor presentation while over this element is forced to use current <see cref="P:System.Windows.FrameworkElement.Cursor"/> settings for the cursor (including on all child elements); otherwise false. The default value is false.
    /// </returns>
    public bool ForceCursor { get; set; }
    /// <summary>
    /// Gets a value that indicates whether this element has been initialized, either during processing by a XAML processor, or by explicitly having its <see cref="M:System.Windows.FrameworkElement.EndInit"/> method called.
    /// </summary>
    /// 
    /// <returns>
    /// true if the element is initialized per the aforementioned XAML processing or method calls; otherwise, false.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public bool IsInitialized { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets a value that indicates whether this element has been loaded for presentation.
    /// </summary>
    /// 
    /// <returns>
    /// true if the current element is attached to an element tree; false if the element has never been attached to a loaded element tree.
    /// </returns>
    public bool IsLoaded { get; }
    /// <summary>
    /// Gets or sets the tool-tip object that is displayed for this element in the user interface (UI).
    /// </summary>
    /// 
    /// <returns>
    /// The tooltip object. See Remarks below for details on why this parameter is not strongly typed.
    /// </returns>
    [Localizability(LocalizationCategory.ToolTip)]
    [Bindable(true)]
    [Category("Appearance")]
    public object ToolTip { get; set; }
    /// <summary>
    /// Gets or sets the context menu element that should appear whenever the context menu is requested through user interface (UI) from within this element.
    /// </summary>
    /// 
    /// <returns>
    /// The context menu assigned to this element.
    /// </returns>
    public ContextMenu ContextMenu { get; set; }
    /// <summary>
    /// Gets the logical parent  element of this element.
    /// </summary>
    /// 
    /// <returns>
    /// This element's logical parent.
    /// </returns>
    public DependencyObject Parent { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; }
    /// <summary>
    /// Gets an enumerator for logical child elements of this element.
    /// </summary>
    /// 
    /// <returns>
    /// An enumerator for logical child elements of this element.
    /// </returns>
    protected internal virtual IEnumerator LogicalChildren { get; }
    /// <summary>
    /// Occurs when the target value changes for any property binding on this element.
    /// </summary>
    public event EventHandler<DataTransferEventArgs> TargetUpdated;
    /// <summary>
    /// Occurs when the source value changes for any existing property binding on this element.
    /// </summary>
    public event EventHandler<DataTransferEventArgs> SourceUpdated;
    /// <summary>
    /// Occurs when the data context for this element changes.
    /// </summary>
    public event DependencyPropertyChangedEventHandler DataContextChanged;
    /// <summary>
    /// Occurs when <see cref="M:System.Windows.FrameworkElement.BringIntoView(System.Windows.Rect)"/> is called on this element.
    /// </summary>
    public event RequestBringIntoViewEventHandler RequestBringIntoView;
    /// <summary>
    /// Occurs when either the <see cref="P:System.Windows.FrameworkElement.ActualHeight"/> or the <see cref="P:System.Windows.FrameworkElement.ActualWidth"/> properties change value on this element.
    /// </summary>
    public event SizeChangedEventHandler SizeChanged;
    /// <summary>
    /// Occurs when this <see cref="T:System.Windows.FrameworkElement"/> is initialized. This event coincides with cases where the value of the <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> property changes from false (or undefined) to true.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public event EventHandler Initialized;
    /// <summary>
    /// Occurs when the element is laid out, rendered, and ready for interaction.
    /// </summary>
    public event RoutedEventHandler Loaded;
    /// <summary>
    /// Occurs when the element is removed from within an element tree of loaded elements.
    /// </summary>
    public event RoutedEventHandler Unloaded;
    /// <summary>
    /// Occurs when any tooltip on the element is opened.
    /// </summary>
    public event ToolTipEventHandler ToolTipOpening;
    /// <summary>
    /// Occurs just before any tooltip on the element is closed.
    /// </summary>
    public event ToolTipEventHandler ToolTipClosing;
    /// <summary>
    /// Occurs when any context menu on the element is opened.
    /// </summary>
    public event ContextMenuEventHandler ContextMenuOpening;
    /// <summary>
    /// Occurs just before any context menu on the element is closed.
    /// </summary>
    public event ContextMenuEventHandler ContextMenuClosing;
  }
}
