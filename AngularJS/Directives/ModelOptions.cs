﻿namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngModelOptions directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-modeloptions (ngModelOptions)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModelOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-modeloptions')")]
        public extern string GetModelOptions();
        
        /// <summary>
        /// Sets a textual value to the ng-modeloptions (ngModelOptions)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModelOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-modeloptions', {value})")]
        public extern void SetModelOptions(string value);
        
        /// <summary>
        /// Removes the ng-modeloptions (ngModelOptions) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModelOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-modeloptions')")]
        public extern void RemoveModelOptions();
    }
}