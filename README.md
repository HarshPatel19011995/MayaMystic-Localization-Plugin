<!-- HEADER -->

<div align="center">

<img src="https://raw.githubusercontent.com/HarshPatel19011995/MayaMystic-Localization-Plugin/main/Documentation~/logo.png" width="90"/>

<h1>🌍 MayaMystic Localization</h1>

<p>
<b>Modular and scalable localization framework for Unity</b>
</p>

</div>

<br>

<!-- BANNER -->

<p align="center">
<img src=""https://raw.githubusercontent.com/HarshPatel19011995/MayaMystic-Localization-Plugin/main/Documentation~/images/banner.png" width="900"/>
</p>

<hr>

<h2>📑 Table of Contents</h2>

<ul>
<li><b><a href="#overview">📌 Overview</a></b></li>
<li><b><a href="#quick-start">⚡ Quick Start</a></b></li>
<li><b><a href="#key-features">✨ Key Features</a></b></li>
<li><b><a href="#supported-languages">🌐 Supported Languages</a></b></li>
<li><b><a href="#architecture">🧠 Architecture</a></b></li>
<li><b><a href="#localization-workflow">🔄 Localization Workflow</a></b></li>
<li><b><a href="#core-components">⚙ Core Components</a></b></li>
<li><b><a href="#package-information">📦 Package Information</a></b></li>
<li><b><a href="#package-structure">📁 Package Structure</a></b></li>
<li><b><a href="#documentation">📚 Documentation</a></b></li>
<li><b><a href="#samples">🧪 Samples</a></b></li>
<li><b><a href="#roadmap">🗺 Roadmap</a></b></li>
<li><b><a href="#changelog">📜 Changelog</a></b></li>
<li><b><a href="#license">📄 License</a></b></li>
<li><b><a href="#author">👤 Author</a></b></li>
</ul>

<hr>

<h2 id="overview">📌 Overview</h2>

<p>
<b>MayaMystic Localization</b> is a modular and reusable runtime localization framework for Unity.
</p>

<p>
It provides scalable utilities for runtime language switching, screen-based localization assets, RTL language support, dynamic font management, localization utilities, and extensible localization workflows.
</p>

<h3>Built-in solutions include</h3>

<ul>
<li>Runtime language switching</li>
<li>Screen-based localization assets</li>
<li>RTL language support</li>
<li>Dynamic font switching</li>
<li>Localized UI utilities</li>
<li>Input field localization support</li>
<li>ScriptableObject-driven architecture</li>
<li>TextMeshPro integration</li>
<li>Extensible localization workflows</li>
</ul>

<hr>

<h2 id="quick-start">⚡ Quick Start</h2>

<details>

<summary><b>Click to expand installation steps</b></summary>

<br>

<h3>Prerequisites</h3>

<ul>
<li>Unity 2021.3 LTS or newer</li>
<li>TextMeshPro package installed</li>
</ul>

<hr>

<h3>1️⃣ Install via Git</h3>

Open <b>Unity Package Manager</b>

<pre>
Window → Package Manager
</pre>

Click

<pre>
+ → Add package from Git URL
</pre>

Paste

<pre>
https://github.com/HarshPatel19011995/MayaMystic-Localization-Plugin.git#v1.0.0
</pre>

<hr>

<h3>2️⃣ Initialize Localization</h3>

<pre>
MMLocalization.Initialize(
    englishLanguageAsset);
</pre>

<hr>

<h3>3️⃣ Change Language</h3>

<pre>
MMLocalization.SetLanguage(
    hebrewLanguageAsset);
</pre>

<hr>

<h3>4️⃣ Apply Localized Text</h3>

<pre>
MMLocalizationUtility.ApplyTextSettings(
    titleText,
    localization.loginHeader,
    language.headerFont,
    isRTL);
</pre>

</details>

<hr>

<h2 id="key-features">✨ Key Features</h2>

<table>
<tr>
<th>Feature</th>
<th>Description</th>
</tr>

<tr>
<td><b>Runtime Language Switching</b></td>
<td>Dynamic language updates during runtime</td>
</tr>

<tr>
<td><b>RTL Language Support</b></td>
<td>Supports Hebrew and future RTL languages</td>
</tr>

<tr>
<td><b>Dynamic Font Management</b></td>
<td>Automatic language-based font switching</td>
</tr>

<tr>
<td><b>Screen-Based Localization</b></td>
<td>Structured localization assets per screen</td>
</tr>

<tr>
<td><b>Localization Utilities</b></td>
<td>Reusable localization helper utilities</td>
</tr>

<tr>
<td><b>TextMeshPro Integration</b></td>
<td>Built-in TMP localization support</td>
</tr>

<tr>
<td><b>Configurable Architecture</b></td>
<td>ScriptableObject-driven localization system</td>
</tr>

<tr>
<td><b>Runtime Event System</b></td>
<td>Global language change event architecture</td>
</tr>
</table>

<hr>

<h2 id="supported-languages">🌐 Supported Languages</h2>

<table>
<tr>
<th>Language</th>
<th>RTL</th>
<th>Status</th>
</tr>

<tr>
<td>English</td>
<td>No</td>
<td>Supported</td>
</tr>

<tr>
<td>Hebrew</td>
<td>Yes</td>
<td>Supported</td>
</tr>

<tr>
<td>Arabic</td>
<td>Yes</td>
<td>Planned</td>
</tr>
</table>

<hr>

<h2 id="architecture">🧠 Architecture</h2>

<details>
<summary><b>View Architecture Diagram</b></summary>

<br>

<pre>
               ┌────────────────────┐
               │   MMLocalization   │
               └─────────┬──────────┘
                         │
        ┌────────────────┼────────────────┐
        ▼                ▼                ▼
┌────────────────┐ ┌──────────────┐ ┌────────────────┐
│ Language Assets│ │ UI Screens   │ │ Localization   │
│ ScriptableObjs │ │ Runtime Flow │ │ Utilities      │
└────────────────┘ └──────────────┘ └────────────────┘
                         │
                         ▼
                ┌─────────────────┐
                │ Runtime UI Text │
                └─────────────────┘
</pre>

<h3>Benefits</h3>

<ul>
<li>Clean modular localization architecture</li>
<li>Reusable runtime localization workflows</li>
<li>Production-ready localization foundation</li>
<li>Scalable multilingual UI system</li>
</ul>

</details>

<hr>

<h2 id="localization-workflow">🔄 Localization Workflow</h2>

<details>

<summary><b>View Localization Workflow</b></summary>

<br>

<pre>
Language Selection
    ↓
MMLocalization
    ↓
Language Changed Event
    ↓
Localized Screen Refresh
    ↓
Localization Utility
    ↓
TMP Text Update
    ↓
Runtime UI Result
</pre>

</details>

<hr>

<h2 id="core-components">⚙ Core Components</h2>

<h3>🔹 MMLocalization</h3>

Responsible for centralized runtime localization operations.

<ul>
<li>Language initialization</li>
<li>Runtime language switching</li>
<li>Global localization access</li>
<li>Language change event system</li>
</ul>

<hr>

<h3>🔹 MMLocalizationUtility</h3>

Provides reusable localization utility workflows.

<ul>
<li>Localized text application</li>
<li>Input field localization</li>
<li>RTL alignment handling</li>
<li>Font application workflows</li>
</ul>

<hr>

<h3>🔹 MMLocalizationLanguageSO</h3>

Stores localization assets and font references for each language.

<hr>

<h2 id="package-information">📦 Package Information</h2>

<table>
<tr><th>Property</th><th>Value</th></tr>
<tr><td>Package Name</td><td><code>com.mayamystic.localization</code></td></tr>
<tr><td>Version</td><td><b>1.0.0</b></td></tr>
<tr><td>Minimum Unity Version</td><td>2021.3 LTS</td></tr>
<tr><td>License</td><td>Proprietary – MayaMystic</td></tr>
</table>

<hr>

<h2 id="package-structure">📁 Package Structure</h2>

<pre>
Runtime/
 ├── Core/
 ├── Config/
 ├── Interfaces/
 ├── Models/
 ├── Utilities/
 ├── Screens/
 ├── Constants/
 └── Examples/

Samples~/
Documentation~/
</pre>

<hr>

<h2 id="documentation">📚 Documentation</h2>

Full documentation:

<pre>
Documentation~/
</pre>

Includes:

<ul>
<li>Getting Started</li>
<li>Localization Architecture</li>
<li>RTL Support</li>
<li>Runtime Language Switching</li>
<li>Localization Utilities</li>
<li>Localization Workflow</li>
</ul>

<hr>

<h2 id="samples">🧪 Samples</h2>

<pre>
Samples~/Basic Usage
</pre>

Demonstrates

<ul>
<li>Runtime language switching</li>
<li>Localized UI refresh</li>
<li>RTL alignment handling</li>
<li>Dynamic font switching</li>
<li>Localization utility usage</li>
</ul>

<hr>

<h2 id="roadmap">🗺 Roadmap</h2>

<table>
<tr><th>Version</th><th>Planned Features</th></tr>
<tr><td>v1.1</td><td>Arabic language support</td></tr>
<tr><td>v1.1</td><td>RTL layout mirroring</td></tr>
<tr><td>v1.2</td><td>Localization editor tools</td></tr>
<tr><td>v1.2</td><td>CSV import/export support</td></tr>
<tr><td>v1.3</td><td>Addressables integration</td></tr>
<tr><td>v1.4</td><td>Runtime downloadable localization</td></tr>
<tr><td>v2.0</td><td>Advanced localization dashboard</td></tr>
</table>

<hr>

<h2 id="changelog">📜 Changelog</h2>

<pre>
CHANGELOG.md
</pre>

<hr>

<h2 id="license">📄 License</h2>

<pre>
LICENSE.md
</pre>

Proprietary – MayaMystic  
All rights reserved.

<hr>

<h2 id="author">👤 Author</h2>

<b>Harsh Patel</b>  
MayaMystic

GitHub  
https://github.com/HarshPatel19011995

<hr>

<h2>⭐ Contributing</h2>

Currently maintained internally.  
External contributions may be accepted in future releases.
