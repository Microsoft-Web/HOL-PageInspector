<a name="HOLTop" />

# Using Page Inspector in Visual Studio 2012 #
---

<a name="Overview" />
## Overview ##

In this Hands-on Lab, you will discover a new tool to find and fix web page issues in Visual Studio - the Page Inspector.

Page Inspector is a new tool that brings browser diagnostics tools to Visual Studio and provides an integrated experience among the browser, ASP.NET, and source code. It renders a web page (HTML, Web Forms, ASP.NET MVC, or Web Pages) directly within the Visual Studio IDE and lets you examine both the source code and the resulting output. Page Inspector enables you to easily decompose a website, rapidly build pages from the ground up, and quickly diagnose issues.

Nowadays we have a number of Web frameworks that create flexible and scalable websites in a timely manner, such as ASP.NET MVC and WebForms. On the other hand, it gets harder to find issues on the pages because the IDE does not support the designer view in template-based pages and dynamic content. Therefore, these websites have to be opened in a browser to see how they appear to a user.

Web developers use external tools to find issues that regularly run in the browser. Then, they return to the IDE and start fixing. This back and forth activity among the IDE, the browser and the profiling tools can be inefficient, and sometimes requires a fresh deployment and cache cleaning each time you want to reproduce an issue.

Page Inspector bridges a gap in Web development between the client (browser tools) and the server (ASP.NET and source code) by bringing together the best of both worlds using a combined set of features.

Using Page Inspector, you can see which elements in the source files (including server-side code) have produced the HTML markup to be rendered in the browser. Page Inspector also lets you modify CSS properties and DOM element attributes to see the changes reflected immediately in the browser.

This hands-on lab will walk you through the Page Inspector features and show you how you can use them to fix issues in Web applications. **This lab contains two exercises using similar flows but targeting different technologies. If you are an ASP.NET MVC Developer, follow exercise one; if you are a WebForms developer follow exercise two**.

<a name="Objectives" />
### Objectives ###

In this hands-on lab, you will learn how to:

- Decompose a Web Site using Page Inspector

- Inspect and preview CSS styles changes with Page Inspector

- Detect and fix issues in your web pages using Page Inspector


<a name="Prerequisites" />
### Prerequisites ###

You must have the following items to complete this lab:

- [Microsoft Visual Studio Express 2012 for Web](http://www.microsoft.com/visualstudio/eng/products/visual-studio-express-for-web) or superior (read [Appendix A](#AppendixA) for instructions on how to install it).

- Internet Explorer 9 or higher

---
<a name="Exercises" />
## Exercises ##

This hands-on lab includes the following exercises:

1. [Exercise 1: Using Page Inspector in ASP.NET MVC Projects](#Exercise1)

1. [Exercise 2: Using Page Inspector in WebForms Projects](#Exercise2)

> **Note:** Each exercise is accompanied by a starting solution, located in the Begin folder of the exercise, that allows you to follow each exercise independently of the others. Inside the source code for an exercise, you will also find an End folder containing a Visual Studio solution with the code that results from completing the steps in the corresponding exercise. You can use these solutions as guidance if you need additional help as you work through this hands-on lab.

Estimated time to complete this lab: **30 minutes**.
 
<a name="Exercise1" />
### Exercise 1: Using Page Inspector in ASP.NET MVC Projects ###

In this exercise, you will learn how to preview and debug an **ASP.NET MVC 4** solution using **Page Inspector**. First, you will perform a brief lap around the tool to learn the features that facilitate the Web debugging process. Then, you will work in a web page that contains styling issues. You will learn how to use Page Inspector to find the source code that generates the issue and fix it.

<a name="Ex1Task1" />
#### Task 1 - Exploring Page Inspector ####

In this task, you will learn how to use the Page Inspector in the context of an ASP.NET MVC 4 project that shows a photo gallery.

1. Open the **Begin** solution located at **Source/Ex1-MVC4/Begin/** folder.

	1. You will need to download some missing NuGet packages before continue. To do this, click the **Project** menu and select **Manage NuGet Packages**.

	1. In the **Manage NuGet Packages** dialog, click **Restore** in order to download missing packages.

	1. Finally, build the solution by clicking **Build** | **Build Solution**.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.

1. In the Solution Explorer, locate **Index.cshtml** view under the **/Views/Home** project folder, right-click it and select **View in Page Inspector**.

 	![Selecting a file to preview in Page Inspector](./images/Selecting-a-file-to-preview-in-Page-Inspector.png?raw=true "Selecting a file to preview in Page Inspector")
 
	_Selecting a file to preview in Page Inspector_

1. The Page Inspector window will show the _/Home/Index_ URL mapped to the source View you selected. 

        
	![ThefirstcontactwithPageInspector](images/ThefirstcontactwithPageInspector.png?raw=true)

	_The first contact with Page Inspector_

  	The Page Inspector tool is integrated in your Visual Studio environment. The inspector contains an embedded browser, together with a powerful HTML profiler. Notice that you do not have to run the solution to see how your pages look.

	>**Note:** When the width of Page Inspector browser is less than the width of the opened page, you will not see the page properly. If that happens, adjust the width of the Page Inspector.

1. Click the **Files** tab in Page Inspector.

	You will see all the source files that are composing the Index page. This feature helps to identify all the elements at a glance, especially when you are working with partial views and templates. Notice that you can also open each of the files if you click the links.

	![The-Files-tab](images/The-Files-tab1.png?raw=true)
 
	_The Files tab_

1. Click the **Toggle Inspection Mode** button, located at the left of the tabs.

	This tool will let you select any element of the page and see its HTML and Razor code.

	![Toggle-Inspection-Mode-button](images/Toggle-Inspection-Mode-button1.png?raw=true)
 
	_Toggle Inspection Mode button_

1. In the Page Inspector browser, move the mouse pointer over the page elements. While you move the mouse pointer over any part of the rendered page, the element type is displayed and the corresponding source markup or code is highlighted in the Visual Studio editor. 

 	![Inspectionmodeinaction](images/Inspectionmodeinaction.png?raw=true)
 
	_Inspection mode in action_

	> **Note:** Do not maximize the Page Inspector window or you will not be able to see the preview tab showing the source code. If you click the element in Page Inspector when it is maximized, the source code of the selection will appear but it will hide the Page Inspector window.

	If you pay attention to the **Index.cshtml** file, you will notice that the portion of source code that generates the selected element is highlighted. This feature facilitates the editing of long source files, providing a direct and fast way to access the code.

 	![Inspectingelements](images/Inspectingelements.png?raw=true)
 
	_Inspecting elements_

1. Click the **Toggle Inspection Mode** button (![Select the HTML tab to display the HTML code rendered in the Page Inspector browser.](./images/Select-the-HTML-tab-to-display-the-HTML-code-rendered-in-the-Page-Inspector-browser..png?raw=true "Select the HTML tab to display the HTML code rendered in the Page Inspector browser.")) to disable the cursor.

1. Select the **HTML** tab to display the HTML code rendered in the Page Inspector browser.

1. In the HTML markup, locate the list item with the Koala link and select it.

	Notice that when you select the code, the corresponding output is automatically highlighted in the browser. This feature is useful to see how an HTML block is rendered on the page.

 	![Selecting HTML element in the page](./images/Selecting-HTML-element-in-the-page.png?raw=true "Selecting HTML element in the page")
 
	_Selecting HTML element in the page_

1. Click the **Toggle Inspection Mode** button to enable _Inspection Mode_ and click the navigation bar. On the right of the HTML code, in the Styles pane, you will see a list with the CSS styles applied to the selected element.

	> **Note:** Since the header is a part of the site layout, Page Inspector will also open _Layout.cshtml file and highlight the segment of code affected.

	![Discoveringstyles](images/Discoveringstyles.png?raw=true)
 
	_Discovering styles and source files of a selected element_

1. With the toggle inspection pointer enabled, move the mouse pointer below the blue featured bar and click the half circle.

 	![Selecting an element](./images/Selecting-an-element.png?raw=true "Selecting an element")
 
	_Selecting an element_

1. In the Styles pane, locate the **background-image** item under the **.main-content** group. **Uncheck** the **background-image** and see what happens. You will notice that the browser will reflect the changes immediately and the circle is hidden.

	>**Note:** The changes you apply on the Page Inspector Styles tab do not affect the original stylesheet. You can uncheck styles or change their values as many times as you want, but they will be restored after refreshing the page.

 	![Enabling and disabling CSS styles](./images/Enabling-and-disabling-CSS-styles.png?raw=true "Enabling and disabling CSS styles")
 
	_Enabling and disabling CSS styles_

1. Now, click the '**your logo here**' text on the header using the inspection mode.

1. In the **Styles** tab, locate the **font-size** CSS attribute under the **.site-title** group. Double-click the attribute value and replace the 2.3 em value with **3 em**, and then press **ENTER**. Notice that the title looks bigger.

 	![Changing CSS values in the Page Inspector](./images/Changing-CSS-values-in-the-Page-Inspector.png?raw=true "Changing CSS values in the Page Inspector")
 
	_Changing CSS values in the Page Inspector_

1. Click the **Trace Styles** tab, located in the right pane of Page Inspector. This is an alternative way to see all the styles applied to the selection, ordered by attribute name.

	![CSSstylestracing](images/CSSstylestracing.png?raw=true)
 
	_CSS styles tracing of the selected element_

1. Another feature of Page Inspector is the Layout pane. Using the inspection mode, select the navigation bar and then click the **Layout** tab on the right pane. You will see the exact size of the selected element, as well as its offset, margin, padding and border size. Notice that you can also modify the values from this view.

 	![Element layout in Page Inspector](./images/Element-layout-in-Page-Inspector.png?raw=true "Element layout in Page Inspector")
 
 	_Element layout in Page Inspector_
 
<a name="Ex1Task2" />
#### Task 2 - Finding and Fixing Style Issues in the Photo Gallery ####

How would you diagnose Web pages issues with previous versions of Visual Studio? You are likely familiar with web debugging tools that run outside the Visual Studio IDE, like Internet Explorer Developer Tools or Firebug. Browsers only understand HTML, scripting and styles, while an underlying framework generates the HTML that will be rendered. For that reason, you often need to deploy the whole site to see how web pages look like.

You had probably followed these steps when you wanted to detect and fix an issue in your web site:

1. Run the Solution from Visual Studio, or deploy the page on the web server.

1. In the browser, open the developer tools you use, or simply open the source code and the styles and try to match the issue.
To find the files involved, you would have used the "Search" or "Search in files" features with the name of the style classes.

1. Once the error is detected, stop the Web browser and the server.

1. Clear the browser cache.

1. Return to Visual Studio to apply a fix. Repeat all the steps to test.

 
As there is no real WYSIWYG in ASP.NET MVC 4, most of the style issues are detected on a later stage, after running or deploying the web application. Now, with Page Inspector, it is possible to preview any page without running the solution.

In this task, you will use the Page inspector and fix some issues the Photo Gallery application.

1. Using Page Inspector, locate the **Register** and the **Log in** links at the left side of the header.

	Notice that the links are not displayed at the expected place on the right, and they are shown like a bulleted list. You will now align the links to the right and restyle them accordingly.

 	![Locating the Register and Log in links](./images/Locating-the-Register-and-Log-on-links.png?raw=true "Locating the Register and Log in links")
 
	_Locating the Register and Log in links_

1. With Toggle Inspection Mode selected, click close to, but not on, the Register link to open its code.

	Notice that the source code of the links is located in the **_LoginPartial.cshtml** file, not the Index.cshtml nor the _Layout.cshtml, which are the places you might look in first place. You have been placed directly in the correct source file.

1. In the **Styles** tab, locate and click the **<section> #login** item, which is the HTML container for these links.

	Notice that the **#login** style is automatically located in **Site.css** after you click. Moreover, the code is now highlighted.

 	![Selecting the CSS styles](./images/Selecting-the-CSS-styles.png?raw=true "Selecting the CSS styles")
 
	_Selecting the CSS styles_

1. Uncomment the **text-align** attribute in the highlighted code by removing the opening and closing characters and save the **Site.css** file.

	Page Inspector is aware of all the different files that compose the current page, and it can detect when any of these files change. It alerts you whenever the current page in browser is not in sync with the source files.

1. In the Page Inspector browser, click the bar located below the address bar to reload the page.

	![Reloading the page](images/Reloading the page.png?raw=true)

	_Reloading the page_


	The links are now at the right, but they still look like a bulleted list. Now, you will remove the bullets and align the links horizontally.

	![Updated page](images/reloading-the-page3.png?raw=true)
 
	_Updated page_

1. Using the inspection mode, select any of the **\<li>** items that contain the “Register” and “Log in” links. Then, click the **\<section> #login** item to access **Styles.css** code.

 	![Finding the style](./images/Finding-the-style.png?raw=true "Finding the style")
 
	_Finding the style_

1. In **Style.css**, uncomment the code for **#login li** items. The style you are adding will hide the bullet and display the items horizontally.

 	![Restyling the login links](./images/Restyling-the-login-links.png?raw=true "Restyling the login links")
 
	_Restyling the login links_

1. Save **Style.css** file and click once on the bar located below the address to reload the page. Notice that the links appear correctly.

 	![Links aligned to the right side](./images/Links-aligned-to-the-right-side.png?raw=true "Links aligned to the right side")
 
	_Links aligned to the right side_

1. Finally, you will change the header title. Use the inspection mode to click **your logo here** text and get to the source code that generates it.

1. Now you are in **_Layout.cshtml**, replace '**your logo here**' text with '**Photo Gallery**'. Save and update the Page Inspector browser.

 	![Assigning a new title](./images/Assigning-a-new-title.png?raw=true "Assigning a new title")
 
	_Assigning a new title_

 	![PhotoGallerypage](images/PhotoGallerypage.png?raw=true)
 
	_Photo Gallery page updated_

1. Finally, selet the **PhotoGallery** project and press **F5** to run the app. Check out all the changes work as expected.

 
---

<a name="Exercise2" />
### Exercise 2: Using Page Inspector in WebForms Projects ###

In this exercise, you will learn how to preview and debug a WebForms solution using Page Inspector. You will first perform a brief lap around the tool to learn the Page Inspector features that facilitate the Web debugging process. Then, you will work in a web page that contains styling issues. You will learn how to use Page Inspector to find the source code that generates the issue and fix it.

<a name="Ex2Task1" />
#### Task 1 - Exploring Page Inspector ####

In this task, you will learn how to use the Page Inspector features in the context of a WebForms project that shows a photo gallery.

1. Open the **Begin** solution located at **Source/Ex2-WebForms/Begin/** folder.

	1. You will need to download some missing NuGet packages before continue. To do this, click the **Project** menu and select **Manage NuGet Packages**.

	1. In the **Manage NuGet Packages** dialog, click **Restore** in order to download missing packages.

	1. Finally, build the solution by clicking **Build** | **Build Solution**.

	>**Note:** One of the advantages of using NuGet is that you don't have to ship all the libraries in your project, reducing the project size. With NuGet Power Tools, by specifying the package versions in the Packages.config file, you will be able to download all the required libraries the first time you run the project. This is why you will have to run these steps after you open an existing solution from this lab.

1. In the Solution Explorer, locate **Default.aspx** page, right-click it and select **View in Page Inspector**.

 	![Opening Default.aspx with Page Inspector](./images/Opening-Default.aspx-with-Page-Inspector.png?raw=true "Opening Default.aspx with Page Inspector")
 
	_Opening Default.aspx with Page Inspector_

1. The Page Inspector window will show Default.aspx. 

 	![Viewing Default.aspx in Page Inspector](./images/Viewing-Default.aspx-in-Page-Inspector.png?raw=true "Viewing Default.aspx in Page Inspector")
 
	_Viewing Default.aspx in Page Inspector_

	The Page Inspector tool is integrated in your Visual Studio environment. The inspector contains an embedded browser, together with a powerful HTML profiler that will show the selected code. Notice that you do not have to run the solution to see how your pages look.

	>**Note:** When the width of Page Inspector browser is less than the width of the opened page, you will not see the page properly. If that happens, adjust the width of the Page Inspector.

1. Click the **Files** tab in Page Inspector. 

	You will see all the source files that are composing the rendered Default page. This is a useful feature to identify all the elements at a glance, especially when you are working with User Controls and Master Pages. Notice that you can also navigate to each of the files.

 	![The Files tab](./images/The-Files-tab2.png?raw=true "The Files tab")
 
	_The Files tab_

1. Click the **Toggle Inspection Mode** button, located at the left of the tabs.

	This tool will let you select any element of the page and see its HTML code and .aspx source.

 	![Toggle Inspection Mode button](./images/Toggle-Inspection-Mode-button.png?raw=true "Toggle Inspection Mode button")
 
	_Toggle Inspection Mode button_

1. In the Page Inspector browser, move the mouse over the page elements. While you move the mouse pointer over any part of the rendered page, the element type is displayed and the corresponding source markup or code is highlighted in the Visual Studio editor.  

 	![Inspection mode in action](./images/Inspection-mode-in-action.png?raw=true "Inspection mode in action")
 
	_Inspection mode in action_

	> **Note:** Do not maximize the Page Inspector window or you will not be able to see the preview tab showing the source code. If you click the element in Page Inspector when it is maximized, the source code of the selection will appear but it will hide the Page Inspector window.

	If you pay attention to **Default.aspx** file, you will notice that the portion of source code that generates the selected element is highlighted. This feature facilitates the edition of long source files, providing a direct and fast way to access the code.

 	![Inspecting elements](./images/Inspecting-elements.png?raw=true "Inspecting elements")
 
	_Inspecting elements_

1. Click the **Toggle Inspection Mode** button (![Select-the-HTML-tab-to-display-the-HTML-code-rendered-in-the-Page-Inspector-browser.](./images/Select-the-HTML-tab-to-display-the-HTML-code-rendered-in-the-Page-Inspector-browser..png?raw=true "Select-the-HTML-tab-to-display-the-HTML-code-rendered-in-the-Page-Inspector-browser.")), located in Page Inspector tabs, to disable the cursor.

1.  Select the **HTML** tab to display the HTML code rendered in the Page Inspector browser.

1. In the HTML code, locate the list item with the Koala link and select it.

	Notice that when you select the code, the corresponding output is automatically highlighted browser. This feature is useful to see how an HTML block is rendered on the page.

 	![Selecting an HTML element in the page](./images/Selecting-an-HTML-element-in-the-page.png?raw=true "Selecting an HTML element in the page")
 
	_Selecting an HTML element in the page_

1. Click the **Toggle Inspection Mode** button to enable _Inspection Mode_ and click the navigation bar. On the right of the HTML code, in the Styles pane, you will see a list with the CSS styles applied to the selected element.

	> **Note:** since the header is a part of the site layout, Page Inspector will also open Site.Master file and highlight the segment of code affected.

 	![DiscoveringstylesWebForms](./images/DiscoveringstylesWebForms.png?raw=true "Discovering styles and source files of a selected element")
 
	_Discovering styles and source files of a selected element_

1. With the toggle inspection pointer enabled, move the mouse pointer below the menu bar and click the blank half circle.

 	![Selecting an element](./images/Selecting-an-element-WebForms.png?raw=true "Selecting an element")
 
	_Selecting an element_

1. In the Styles pane, locate the **background-image** item under the **.main-content** group. **Uncheck** the **background-image** and see what happens. You will notice that the browser will reflect the changes immediately and the circle is hidden.

	>**Note:** The changes you apply on the Page Inspector Styles tab do not affect the original stylesheet. You can uncheck styles or change their values as many times as you want, but they will be restored after refreshing the page.

	![Enabling and disabling CSS styles2](./images/Enabling-and-disabling-CSS-styles2.png?raw=true "Enabling and disabling CSS styles")
 
	_Enabling and disabling CSS styles_

1. Now, click the '**your** **logo here'** text on the header using the inspection mode.

1. In the **Styles** tab, locate the **font-size** CSS attribute under the **.site-title** group. Double-click the attribute once to edit its value. Replace the 2.3em value with **3em**, and then press ENTER. Notice that the title looks bigger.

 	![Changing CSS values in the Page Inspector2](./images/Changing-CSS-values-in-the-Page-Inspector.png?raw=true "Changing CSS values in the Page Inspector")
 
	_Changing CSS values in the Page Inspector_

1. Click the **Trace Styles** tab, located in the right pane of Page Inspector. This is an alternative way to see all the styles applied to the selection, ordered by attribute name.

 	![CSS styles tracing of the selected element](./images/CSS-styles-tracing-of-the-selected-element.png?raw=true "CSS styles tracing of the selected element")
 
	_CSS styles tracing of the selected element_

1. Another feature of Page Inspector is the Layout pane. Using the inspection mode, select the navigation bar and then click the **Layout** tab on the right pane. You will see the exact size of the selected element, as well as its offset, margin, padding and border size. Notice that you can also modify the values from this view.

 	![Element layout in Page Inspector](./images/Element-layout-in-Page-Inspector.png?raw=true "Element layout in Page Inspector")
 
 	_Element layout in Page Inspector_
 

<a name="Ex2Task2" />
#### Task 2 - Finding and Fixing Style Issues in the Photo Gallery ####

How would you diagnose Web pages issues with previous versions of Visual Studio? You are likely familiar with web debugging tools that run outside the Visual Studio IDE, like Internet Explorer Developer Tools or Firebug. Browsers only understand HTML, scripting and styles, while an underlying framework generates the HTML that will be rendered. For that reason, you often need to deploy the whole site to see how web pages look like.

You had probably followed these steps when you wanted to detect and fix an issue in your web site:

1. Run the Solution from Visual Studio, or deploy the page on the web server.

1. In the browser, open the developer tools you use, or simply open the source code and the styles and try to match the issue.
To find the files involved, you'd have used the "Search" or "Search in files" features with the name of the style classes.

1. Once the error is detected, stop the Web browser and the server.

1. Clear the browser cache.

1. Return to Visual Studio to apply a fix. Repeat all the steps to test.

 
As there is no real WYSIWYG in ASP.NET WebForms, some style issues are detected on a later stage, after running or deploying. Now, with Page Inspector, it is possible to preview any page without running the solution.

In this task, you will use the Page inspector for fixing some issues of the Photo Gallery application. In the following steps, you will detect and quickly fix some simple styling issue in the header.

1. Using Page Inspection, locate the **Register** and the **Log In** links at the left side of the header.

	Notice that the link is not displayed at the expected place on the right. You will now align the link to the right and restyle it accordingly.

 	![Log in link positioned on the left](./images/Locating-the-Register-and-Log-on-links.png?raw=true "Log in link positioned on the left")
 
	_Log In link positioned on the left_

1. With Toggle Inspection Mode selected, select the Log In link to open its code.

	Notice that the link source code is located in the **Site.Master** file, not in the Default.aspx page which is the place you might look in first place; you have been placed directly in the correct source file.

1. In the **Styles** tab, locate and click the **\<section> #login** item, which is the HTML container for these links.

	Notice that the **#login** style is automatically located in **Site.css** after you click. Moreover, the code is now highlighted.

 	![Selecting the CSS styles](./images/Selecting-the-CSS-styles.png?raw=true "Selecting the CSS styles")
 
	_Selecting the CSS styles_

1. Uncomment the **text-align** attribute in the highlighted code by removing the opening and closing characters and save the **Site.css** file.

	Page Inspector is aware of all the different files that compose the current page, and it can detect when any of these files change. It alerts you whenever the current page in browser is not in sync with the source files.

1. In the Page Inspector browser, click the bar located below the address bar to save the changes and reload the page.

	![Reloadingthepage](images/Reloadingthepage.png?raw=true)
 
	_Reloading the page_

	The links are now at the right, but they still look like a bulleted list. Now, you will remove the bullets and align the links horizontally.

	![Updated page](images/reloading-the-page3.png?raw=true)
 
	_Updated page_

1. Using the inspection mode, select any of the **\<li>** items that contain the “Register” and “Log in” links. Then, click the **\<section> #login** item to access **Styles.css** code.

 	![Finding the style](./images/Finding-the-style.png?raw=true "Finding the style")
 
	_Finding the style_

1. In **Style.css**, uncomment the code for **#login li** items. The style you are adding will hide the bullet and display the items horizontally.

 	![Restyling the login links](./images/Restyling-the-login-links.png?raw=true "Restyling the login links")
 
	_Restyling the login links_

1. Save **Style.css** file and click once on the bar located below the address to reload the page. Notice that the links appear correctly.

 	![Links aligned to the right side](./images/Links-aligned-to-the-right-side.png?raw=true "Links aligned to the right side")
 
	_Links aligned to the right side_

1. Finally, you will change the header title. Instead of searching for the '**your logo here'** text in all the files, use the inspection mode to click the text and get to source code that generates it.

 	![Finding the site title](./images/Finding-the-site-title.png?raw=true "Finding the site title")
 
	_Finding the site title_

1. Now you are in **Site.Master**, replace the '**your logo here**' text with '**Photo Gallery**'. Save and update the Page Inspector browser.

 	![Photo Gallery page updated](./images/PhotoGallerypage.png?raw=true "Photo Gallery page updated")
 
	_Photo Gallery page updated_

1. Finally press **F5** to run the app the check out all the changes work as expected.

>**Note:** Additionally, you can deploy this application to Windows Azure Web Sites following [Appendix B: Publishing an ASP.NET MVC 4 Application using Web Deploy](#AppendixB).

---

<a name="Summary" />
## Summary ##

By completing this Hands-On Lab, you have learnt how to use Page Inspector to preview your Web application without having to rebuild and run the Web site in a browser. In addition, you have learnt how to quickly find and fix bugs by accessing directly from the rendered output to the source code.

<a name="AppendixA" />
## Appendix A: Installing Visual Studio Express 2012 for Web ##

You can install **Microsoft Visual Studio Express 2012 for Web** or another "Express" version using the **[Microsoft Web Platform Installer](http://www.microsoft.com/web/downloads/platform.aspx)**. The following instructions guide you through the steps required to install _Visual studio Express 2012 for Web_ using _Microsoft Web Platform Installer_.

1. Go to [http://go.microsoft.com/?linkid=9810169](http://go.microsoft.com/?linkid=9810169). Alternatively, if you already have installed Web Platform Installer, you can open it and search for the product "_Visual Studio Express 2012 for Web with Windows Azure SDK_".

1. Click on **Install Now**. If you do not have **Web Platform Installer** you will be redirected to download and install it first.

1. Once **Web Platform Installer** is open, click **Install** to start the setup.

	![Install Visual Studio Express](images/install-visual-studio-express.png?raw=true "Install Visual Studio Express")

 	_Install Visual Studio Express_

1. Read all the products' licenses and terms and click **I Accept** to continue.

	![Accepting the license terms](images/accepting-the-license-terms.png?raw=true)

	_Accepting the license terms_

1. Wait until the downloading and installation process completes.

	![Installation progress](images/installation-progress.png?raw=true)

	_Installation progress_

1. When the installation completes, click **Finish**.

	![Installation completed](images/installation-completed.png?raw=true)

	_Installation completed_

1. Click **Exit** to close Web Platform Installer.

1. To open Visual Studio Express for Web, go to the **Start** screen and start writing "**VS Express**", then click on the **VS Express for Web** tile.

	![VS Express for Web tile](images/vs-express-for-web-tile.png?raw=true)

	_VS Express for Web tile_

<a name="AppendixB" />
## Appendix B: Publishing an ASP.NET MVC 4 Application using Web Deploy ##

This appendix will show you how to create a new web site from the Windows Azure Management Portal and publish the application you obtained by following the lab, taking advantage of the Web Deploy publishing feature provided by Windows Azure.

<a name="ApxBTask1"></a>
#### Task 1 – Creating a New Web Site from the Windows Azure Portal ####

1. Go to the [Windows Azure Management Portal](https://manage.windowsazure.com/) and sign in using the Microsoft credentials associated with your subscription.

	![Log on to Windows Azure portal](images/login.png?raw=true "Log on to Windows Azure portal")

	_Log on to Windows Azure Management Portal_

1. Click **New** on the command bar.

	![Creating a new Web Site](images/new-website.png?raw=true "Creating a new Web Site")

	_Creating a new Web Site_

1. Click **Compute** | **Web Site**. Then select **Quick Create** option. Provide an available URL for the new web site and click **Create Web Site**.

	> **Note:** A Windows Azure Web Site is the host for a web application running in the cloud that you can control and manage. The Quick Create option allows you to deploy a completed web application to the Windows Azure Web Site from outside the portal. It does not include steps for setting up a database.

	![Creating a new Web Site using Quick Create](images/quick-create.png?raw=true "Creating a new Web Site using Quick Create")

	_Creating a new Web Site using Quick Create_

1. Wait until the new **Web Site** is created.

1. Once the Web Site is created click the link under the **URL** column. Check that the new Web Site is working.

	![Browsing to the new web site](images/navigate-website.png?raw=true "Browsing to the new web site")

	_Browsing to the new web site_

	![Web site running](images/website-working.png?raw=true "Web site running")

	_Web site running_

1. Go back to the portal and click the name of the web site under the **Name** column to display the management pages.

	![Opening the web site management pages](images/go-to-the-dashboard.png?raw=true "Opening the web site management pages")
	
	_Opening the Web Site management pages_

1. In the **Dashboard** page, under the **quick glance** section, click the **Download publish profile** link.

	> **Note:** The _publish profile_ contains all of the information required to publish a web application to a Windows Azure website for each enabled publication method. The publish profile contains the URLs, user credentials and database strings required to connect to and authenticate against each of the endpoints for which a publication method is enabled. **Microsoft WebMatrix 2**, **Microsoft Visual Studio Express for Web** and **Microsoft Visual Studio 2012** support reading publish profiles to automate configuration of these programs for publishing web applications to Windows Azure websites. 

	![Downloading the web site publish profile](images/download-publish-profile.png?raw=true "Downloading the web site publish profile")
	
	_Downloading the Web Site publish profile_

1. Download the publish profile file to a known location. Further in this exercise you will see how to use this file to publish a web application to a Windows Azure Web Sites from Visual Studio.

	![Saving the publish profile file](images/save-link.png?raw=true "Saving the publish profile")
	
	_Saving the publish profile file_

<a name="ApxBTask2"></a>
#### Task 2 – Configuring the Database Server ####

If your application makes use of SQL Server databases you will need to create a SQL Database server. If you want to deploy a simple application that does not use SQL Server you might skip this task.

1. You will need a SQL Database server for storing the application database. You can view the SQL Database servers from your subscription in the Windows Azure Management portal at **Sql Databases** | **Servers** | **Server's Dashboard**. If you do not have a server created, you can create one using the **Add** button on the command bar. Take note of the **server name and URL, administrator login name and password**, as you will use them in the next tasks. Do not create the database yet, as it will be created in a later stage.

	![SQL Database Server Dashboard](images/sql-database-server-dashboard.png?raw=true "SQL Database Server Dashboard")

	_SQL Database Server Dashboard_

1. In the next task you will test the database connection from Visual Studio, for that reason you need to include your local IP address in the server's list of **Allowed IP Addresses**. To do that, click **Configure**, select the IP address from **Current Client IP Address** and paste it on the **Start IP Address** and **End IP Address** text boxes and click the ![add-client-ip-address-ok-button](images/add-client-ip-address-ok-button.png?raw=true) button.

	![Adding Client IP Address](images/add-client-ip-address.png?raw=true)

	_Adding Client IP Address_

1. Once the **Client IP Address** is added to the allowed IP addresses list, click on **Save** to confirm the changes.

	![Confirm Changes](images/add-client-ip-address-confirm.png?raw=true)

	_Confirm Changes_

<a name="ApxBTask3"></a>
#### Task 3 – Publishing an ASP.NET MVC 4 Application using Web Deploy ####

1. Go back to the ASP.NET MVC 4 solution. In the **Solution Explorer**,  right-click the web site project and select **Publish**.

	![Publishing the Application](images/publishing-the-application.png?raw=true "Publishing the Application")

	_Publishing the web site_

1. Import the publish profile you saved in the first task.

	![Importing the publish profile](images/importing-the-publish-profile.png?raw=true "Importing the publish profile")

	_Importing publish profile_

1. Click **Validate Connection**. Once Validation is complete click **Next**.

	> **Note:** Validation is complete once you see a green checkmark appear next to the Validate Connection button.

	![Validating connection](images/validating-connection.png?raw=true "Validating connection")

	_Validating connection_

1. In the **Settings** page, under the **Databases** section, click the button next to your database connection's textbox (i.e. **DefaultConnection**).

	![Web deploy configuration](images/web-deploy-configuration.png?raw=true "Web deploy configuration")

	_Web deploy configuration_

1. Configure the database connection as follows:
	* In the **Server name** type your SQL Database server URL using the _tcp:_ prefix.
	* In **User name** type your server administrator login name.
	* In **Password** type your server administrator login password.
	* Type a new database name.

	![Configuring destination connection string](images/configuring-destination-connection-string.png?raw=true "Configuring destination connection string")

	_Configuring destination connection string_

1. Then click **OK**. When prompted to create the database click **Yes**.

	![Creating the database](images/creating-the-database.png?raw=true "Creating the database string")

	_Creating the database_

1. The connection string you will use to connect to SQL Database in Windows Azure is shown within Default Connection textbox. Then click **Next**.

	![Connection string pointing to SQL Database](images/sql-database-connection-string.png?raw=true "Connection string pointing to SQL Database")

	_Connection string pointing to SQL Database_

1. In the **Preview** page, click **Publish**.

	![Publishing the web application](images/publishing-the-web-application.png?raw=true "Publishing the web application")

	_Publishing the web application_

1. Once the publishing process finishes, your default browser will open the published web site.
