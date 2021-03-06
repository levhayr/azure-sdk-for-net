// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Update Virtual Machine Image operation.
    /// </summary>
    public partial class VirtualMachineOSImageUpdateParameters
    {
        private string _description;
        
        /// <summary>
        /// Optional. Specifies the description of the OS image.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _eula;
        
        /// <summary>
        /// Optional. Specifies the End User License Agreement that is
        /// associated with the image. The value for this element is a string,
        /// but it is recommended that the value be a URL that points to a
        /// EULA.
        /// </summary>
        public string Eula
        {
            get { return this._eula; }
            set { this._eula = value; }
        }
        
        private string _iconUri;
        
        /// <summary>
        /// Optional. Specifies the URI to the icon that is displayed for the
        /// image in the Management Portal.
        /// </summary>
        public string IconUri
        {
            get { return this._iconUri; }
            set { this._iconUri = value; }
        }
        
        private string _imageFamily;
        
        /// <summary>
        /// Optional. Specifies a value that can be used to group OS images.
        /// </summary>
        public string ImageFamily
        {
            get { return this._imageFamily; }
            set { this._imageFamily = value; }
        }
        
        private bool? _isPremium;
        
        /// <summary>
        /// Optional. Indicates if the image contains software or associated
        /// services that will incur charges above the core price for the
        /// virtual machine.
        /// </summary>
        public bool? IsPremium
        {
            get { return this._isPremium; }
            set { this._isPremium = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Required. Specifies the friendly name of the image to be updated.
        /// You cannot use this operation to update images provided by the
        /// Azure platform.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private string _language;
        
        /// <summary>
        /// Optional. Specifies the language of the image. The Language element
        /// is only available using version 2013-03-01 or higher.
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }
        
        private Uri _privacyUri;
        
        /// <summary>
        /// Optional. Specifies the URI that points to a document that contains
        /// the privacy policy related to the OS image.
        /// </summary>
        public Uri PrivacyUri
        {
            get { return this._privacyUri; }
            set { this._privacyUri = value; }
        }
        
        private System.DateTime? _publishedDate;
        
        /// <summary>
        /// Optional. Specifies the date when the OS image was added to the
        /// image repository.
        /// </summary>
        public System.DateTime? PublishedDate
        {
            get { return this._publishedDate; }
            set { this._publishedDate = value; }
        }
        
        private string _recommendedVMSize;
        
        /// <summary>
        /// Optional. Specifies the size to use for the virtual machine that is
        /// created from the OS image.
        /// </summary>
        public string RecommendedVMSize
        {
            get { return this._recommendedVMSize; }
            set { this._recommendedVMSize = value; }
        }
        
        private bool? _showInGui;
        
        /// <summary>
        /// Optional. When published, should this image show up in the windows
        /// azure image gallery or not. True by default.
        /// </summary>
        public bool? ShowInGui
        {
            get { return this._showInGui; }
            set { this._showInGui = value; }
        }
        
        private string _smallIconUri;
        
        /// <summary>
        /// Optional. Specifies the URI to the small icon that is displayed
        /// when the image is presented in the Azure Management Portal. The
        /// SmallIconUri element is only available using version 2013-03-01 or
        /// higher.
        /// </summary>
        public string SmallIconUri
        {
            get { return this._smallIconUri; }
            set { this._smallIconUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineOSImageUpdateParameters class.
        /// </summary>
        public VirtualMachineOSImageUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineOSImageUpdateParameters class with required
        /// arguments.
        /// </summary>
        public VirtualMachineOSImageUpdateParameters(string label)
            : this()
        {
            if (label == null)
            {
                throw new ArgumentNullException("label");
            }
            this.Label = label;
        }
    }
}
