#Using Page Inspector in Visual Studio 11#

## Overview ##

In this Hands-on Lab, you will discover a new tool to find and fix web page issues in Visual Studio - the Page Inspector.

Page Inspector is a new tool that brings browser diagnostics tools to Visual Studio and provides an integrated experience among the browser, ASP.NET, and source code. It renders a web page (HTML, Web Forms, ASP.NET MVC, or Web Pages) directly within the Visual Studio IDE and lets you examine both the source code and the resulting output. Page Inspector enables you to easily decompose a website, rapidly build pages from the ground up, and quickly diagnose issues.

Nowadays we have a number of Web frameworks that create flexible and scalable websites in a timely manner, such as ASP.NET MVC and WebForms. On the other hand, it gets harder to find issues on the pages because the IDE does not support the designer view in template-based pages and dynamic content. Therefore, these websites have to be opened in a browser to see how they appear to a user.

Web developers use external tools to find issues that regularly run in the browser. Then, they return to the IDE and start fixing. This back and forth activity among the IDE, the browser and the profiling tools can be inefficient, and sometimes requires a fresh deployment and cache cleaning each time you want to reproduce an issue.

Page Inspector bridges a gap in Web development between the client (browser tools) and the server (ASP.NET and source code) by bringing together the best of both worlds using a combined set of features.

Using Page Inspector, you can see which elements in the source files (including server-side code) have produced the HTML markup to be rendered in the browser. Page Inspector also lets you modify CSS properties and DOM element attributes to see the changes reflected immediately in the browser.

This hands-on lab will walk you through the Page Inspector features and show you how you can use them to fix issues in Web applications. **This lab contains two exercises using similar flows but targeting different technologies. If you are an ASP.NET MVC Developer, follow exercise one; if you are a WebForms developer follow exercise two**.

### Objectives ###

In this hands-on lab, you will learn how to:

- Decompose a Web Site using Page Inspector

- Inspect and preview CSS styles changes with Page Inspector

- Detect and fix issues in your web pages using Page Inspector

 
### Prerequisites ###

- [Microsoft Visual Studio 11  Beta](http://go.microsoft.com/fwlink/?LinkId=240160)

- Page Inspector (included in the Microsoft Visual Studio 11 Beta installation)

- Internet Explorer 9

- ASP.NET MVC 4 (only if you are performing exercise 1; included in the Microsoft Visual Studio 11 Beta installation)

> **Note:** Page Inspector hosts the current version of Internet Explorer in Visual Studio. For full functionality, you must have Internet Explorer 9 installed on your computer. You do not need to have Internet Explorer Platform Preview (also called Internet Explorer 10 Test Drive) installed. 
 
## Exercises ##

This hands-on lab includes the following exercises:

1. Using Page Inspector in ASP.NET MVC Projects

1. Using Page Inspector in WebForms Projects

> **Note:** Each exercise is accompanied by a starting solution-located in the Begin folder of the exercise-that allows you to follow each exercise independently of the others. Inside the source code for an exercise, you will also find an End folder containing a Visual Studio solution with the code that results from completing the steps in the corresponding exercise. You can use these solutions as guidance if you need additional help as you work through this hands-on lab.

 
### Exercise 1: Using Page Inspector in ASP.NET MVC Projects ###

In this exercise, you will learn how to preview and debug an **ASP.NET MVC 4** solution using **Page Inspector**. First, you will perform a brief lap around the tool to learn the features that facilitate the Web debugging process. Then, you will work in a web page that contains styling issues. You will learn how to use Page Inspector to find the source code that generates the issue and fix it.

#### Task 1 - Exploring Page Inspector ####

In this task, you will learn how to use the Page Inspector in the context of an ASP.NET MVC 4 project that shows a photo gallery.

  1. Open **Visual Studio 11** and open the **PageInspector-MVC-Begin.sln** solution located in **Source\Ex1-MVC4\Begin** from this lab's folder. You will use this solution for exploring Page Inspector. 

  1. In the Solution Explorer, locate **Index.cshtml** view under the **/Views/Home** project folder, right-click it and select **View in Page Inspector**.

 	![Selecting a file to preview in Page Inspector](./images/Selecting-a-file-to-preview-in-Page-Inspector.png?raw=true "Selecting a file to preview in Page Inspector")
 
	_Selecting a file to preview in Page Inspector_

  1. You will notice that Visual Studio will prompt for permission before enabling the tool in your project. Click **YES.**

 	![Enabling Page Inspector in a Visual Studio project](./images/Enabling-Page-Inspector-in-a-Visual-Studio-project.png?raw=true "Enabling Page Inspector in a Visual Studio project")
 
	_Enabling Page Inspector in a Visual Studio project_

	To generate the metadata that is required for some of its features, Page Inspector must instrument the project by adding the following setting to the <appSetting> element in the **Web.config** file. You can use Page Inspector even if this setting is disabled or it is missing. However, some features like the source selection mapping will not work under these conditions.

	````HTML
	<add key="VisualStudioDesignTime:Enabled" value="true" />
````
  1. The Page Inspector window will show the /Home/Index URL mapped to the source View you selected. 

        
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

  1. Click the **Toggle Inspection Mode** button (![Select the HTML tab to display the HTML code rendered in the Page Inspector browser.](./images/Select-the-HTML-tab-to-display-the-HTML-code-rendered-in-the-Page-Inspector-browser..png?raw=true "Select the HTML tab to display the HTML code rendered in the Page Inspector browser.")
) to disable the cursor.

  1. Select the **HTML** tab to display the HTML code rendered in the Page Inspector browser.

  1. In the HTML markup, locate the list item with the Koala link and select it.

	Notice that when you select the code, the corresponding output is automatically highlighted in the browser. This feature is useful to see how an HTML block is rendered on the page.

 	![Selecting HTML element in the page](./images/Selecting-HTML-element-in-the-page.png?raw=true "Selecting HTML element in the page")
 
	_Selecting HTML element in the page_

  1. Click the **Toggle Inspection Mode** button to enable _Inspection Mode_ and click the navigation bar. On the right of the HTML code, in the Styles pane, you will see a list with the CSS styles applied to the selected element.

	> **Note:** Since the header is a part of the site layout, Page Inspector will also open _Layout.cshtml file and highlight the segment of code affected.

	![Discoveringstyles](images/Discoveringstyles.png?raw=true)
 
	_Discovering styles and source files of a selected element_

  1. With the toggle inspection pointer enabled, move the mouse pointer below the menu bar and click the blank half circle.

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
 
#### Task 2 - Finding and Fixing Style Issues in the Photo Gallery ####

How would you diagnose Web pages issues with previous versions of Visual Studio? You are likely familiar with web debugging tools that run outside the Visual Studio IDE, like Internet Explorer Developer Tools or Firebug. Browsers only understand HTML, scripting and styles, while an underlying framework generates the HTML that will be rendered. For that reason, you often need to deploy the whole site to see how web pages look like.

You had probably followed these steps when you wanted to detect and fix an issue in your web site:

1. Run the Solution from Visual Studio, or deploy the page on the web server.

1. In the browser, open the developer tools you use, or simply open the source code and the styles and try to match the issue.
To find the files involved, you would have used the "Search" or "Search in files" features with the name of the style classes.

1. Once the error is detected, stop the Web browser and the server.

1. Clear the browser cache.

1. Return to Visual Studio to apply a fix. Repeat all the steps to test.

 
As there is no real WYSIWYG in ASP.NET MVC, most of the style issues are detected on a later stage, after running or deploying the web application. Now, with Page Inspector, it is possible to preview any page without running the solution.

In this task, you will use the Page inspector and fix some issues the Photo Gallery application.

1. Using Page Inspector, locate the **Register** and the **Log on** links at the left side of the header.

	Notice that the links are not displayed at the expected place on the right, and they are shown like a bulleted list. You will now align the links to the right and restyle them accordingly.

 	![Locating the Register and Log on links](./images/Locating-the-Register-and-Log-on-links.png?raw=true "Locating the Register and Log on links")
 
	_Locating the Register and Log on links_

1. With Toggle Inspection Mode selected, click close to, but not on, the Register link to open its code.

	Notice that the source code of the links is located in the **_LogOnPartial.cshtml** file, not the Index.cshtml nor the _Layout.cshtml, which are the places you might look in first place. You have been placed directly in the correct source file.

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

	![Reloading the page](images/reloading-the-page3.png?raw=true)
 
	_Reloading the page_

1. Using the inspection mode, select any of the **\<li>** items that contain the “Register” and “Log On” links. Then, click the **\<section> #login** item to access Styles.css code.

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

1. Finally press **F5** to run the app. Check out all the changes work as expected.

 
### Exercise 2: Using Page Inspector in WebForms Projects ###

In this exercise, you will learn how to preview and debug a WebForms solution using Page Inspector. You will first perform a brief lap around the tool to learn the Page Inspector features that facilitate the Web debugging process. Then, you will work in a web page that contains styling issues. You will learn how to use Page Inspector to find the source code that generates the issue and fix it.

#### Task 1 - Exploring Page Inspector ####

In this task, you will learn how to use the Page Inspector features in the context of a WebForms project that shows a photo gallery.

1. Open **Visual Studio 11** and open the **PageInspector-WebForms-Begin.sln** solution located in **Source\Ex2-WebForms\Begin** from this lab's folder.

1. In the Solution Explorer, locate **Default.aspx** page, right-click it and select **View in Page Inspector**.

 	![Selecting a file to preview in Page Inspector](./images/Selecting-a-file-to-preview-in-Page-Inspector.png?raw=true "Selecting a file to preview in Page Inspector")
 
	_Selecting a file to preview in Page Inspector_

1. You will notice that Visual Studio will prompt for permission before enabling the tool in your project. Click **YES.**

 	![Enabling Page Inspector in a Visual Studio project](./images/Enabling-Page-Inspector-in-a-Visual-Studio-project.png?raw=true "Enabling Page Inspector in a Visual Studio project")
 
	_Enabling Page Inspector in a Visual Studio project_

	To generate the metadata that is required for some of its features, Page Inspector must instrument the project by adding the following setting to the <appSetting> element in Web.config file. You can use Page Inspector even with this setting disabled or missing. However, some features will not work, such as source selection mapping.

	````HTML
	<add key="VisualStudioDesignTime:Enabled" value="true" />
````

	

1. The Page Inspector window will show Default.aspx. 

 	![The first contact with Page Inspector](./images/The-first-contact-with-Page-Inspector.png?raw=true "The first contact with Page Inspector")
 
	_The first contact with Page Inspector_

	The Page Inspector tool is integrated in your Visual Studio environment. The inspector contains an embedded browser, together with a powerful HTML profiler that will show the selected code. Notice that you do not have to run the solution to see how your pages look.

	>**Note:** When the width of Page Inspector browser is less than the width of the opened page, you will not see the page properly. If that happens, adjust the width of the Page Inspector.

1. Click the **Files** tab in Page Inspector. 

	You will see all the source files that are composing the rendered Default page. This is a useful feature to identify all the elements at a glance, especially when you are working with User Controls and Master Pages. Notice that you can also navigate to each of the files.

 	![The Files tab](./images/The-Files-tab.png?raw=true "The Files tab")
 
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

1. Click the **Toggle Inspection Mode** button (![the cursor.](./images/the-cursor..png?raw=true "the cursor.")
 ), located in Page Inspector tabs, to disable the cursor.

1.  Select the **HTML** tab to display the HTML code rendered in the Page Inspector browser.

1. In the HTML code, locate the list item with the Koala link and select it.

	Notice that when you select the code, the corresponding output is automatically highlighted browser. This feature is useful to see how an HTML block is rendered on the page.

 	![Selecting an HTML element in the page](./images/Selecting-an-HTML-element-in-the-page.png?raw=true "Selecting an HTML element in the page")
 
	_Selecting an HTML element in the page_

1. Click the **Toggle Inspection Mode** button to enable _Inspection Mode_ and click the navigation bar. On the right of the HTML code, in the Styles pane, you will see a list with the CSS styles applied to the selected element.

	> **Note:** since the header is a part of the site layout, Page Inspector will also open Site.Master file and highlight the segment of code affected.

 	![Discovering styles and source files of a selected element](./images/Discovering-styles-and-source-files-of-a-selected-element.png?raw=true "Discovering styles and source files of a selected element")
 
	_Discovering styles and source files of a selected element_

1. With the toggle inspection pointer enabled, move the mouse pointer below the menu bar and click the blank half circle.

 	![Selecting an element](./images/Selecting-an-element.png?raw=true "Selecting an element")
 
	_Selecting an element_

1. In the Styles pane, locate the **background-image** item under the **.main-content** group. **Uncheck** the **background-image** and see what happens. You will notice that the browser will reflect the changes immediately and the circle is hidden.

	>**Note:** The changes you apply on the Page Inspector Styles tab do not affect the original stylesheet. You can uncheck styles or change their values as many times as you want, but they will be restored after refreshing the page.

	![Enabling and disabling CSS styles](./images/Enabling-and-disabling-CSS-styles.png?raw=true "Enabling and disabling CSS styles")
 
	_Enabling and disabling CSS styles_

1. Now, click the '**your** **logo here'** text on the header using the inspection mode.

1. In the **Styles** tab, locate the **font-size** CSS attribute under the **.site-title** group. Click the attribute once to edit its value. Replace the 2.3em value with **5em**, and then press ENTER. Notice that the title looks bigger.

 	![Changing CSS values in the Page Inspector](./images/Changing-CSS-values-in-the-Page-Inspector.png?raw=true "Changing CSS values in the Page Inspector")
 
	_Changing CSS values in the Page Inspector_

1. Click the **Trace Styles** tab, located in the right pane of Page Inspector. This is an alternative way to see all the styles applied to the selection, ordered by attribute name.

 	![CSS styles tracing of the selected element](./images/CSS-styles-tracing-of-the-selected-element.png?raw=true "CSS styles tracing of the selected element")
 
	_CSS styles tracing of the selected element_

1. Another feature of Page Inspector is the Layout pane. Using the inspection mode, select the navigation bar and then click the **Layout** tab on the right pane. You will see the exact size of the selected element, as well as its offset, margin, padding and border size. Notice that you can also modify the values from this view.

 	![Element layout in Page Inspector](./images/Element-layout-in-Page-Inspector.png?raw=true "Element layout in Page Inspector")
 
 	_Element layout in Page Inspector_
 

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

In this task, you will use the Page inspector for fixing some issues the Photo Gallery application. In the following steps, you will detect and quickly fix some simple styling issue in the header.

1. Using Page Inspection, locate the **Log In** link at the left side of the header.

	Notice that the link is not displayed at the expected place on the right. You will now align the link to the right and restyle it accordingly.

 	![Log on link positioned on the left](./images/Log-on-link-positioned-on-the-left.png?raw=true "Log on link positioned on the left")
 
	_Log on link positioned on the left_

1. With Toggle Inspection Mode selected, select the Log In link to open its code.

	Notice that the link source code is located in the **Site.Master** file, not in the Default.aspx page which is the place you might look in first place; you have been placed directly in the correct source file.

1. The page is using the LoginView control in the same way it is used by default in the Web Application project template. To make it look nicer, remove the brackets between the Log In and Log Out controls.

 	![Brackets Removed](./images/Brackets-Removed.png?raw=true "Brackets Removed")
 
	_Brackets Removed_

	Page Inspector is aware of all the different files that compose the current page, and it can detect when any of these files change. It alerts you whenever the current page in browser is not in sync with the source files.

1. In the Page Inspector browser, click the bar located below the address bar to save the changes and reload the page.

	![Reloadingthepage](images/Reloadingthepage.png?raw=true)
 
	_Reloading the page_

	The Log In link looks nicer without the brackets, now, you will move it to the right side. To do this, you will locate the styles being applied to the Login section and update it to align its content to the right.

	![Reloading the page](./images/Reloading-the-page.png?raw=true "Reloading the page")
 
	_Reloading the page_

1. In the **Styles** tab, locate and click the **<section> #login** item, which is the HTML container for the link.

	Notice that **Site.css** opened and the corresponding style is selected.

 	![Selecting the CSS styles](./images/Selecting-the-CSS-styles.png?raw=true "Selecting the CSS styles")
 
	_Selecting the CSS styles_

1. Uncomment the **text-align** attribute in the highlighted code by removing the opening and closing characters and save the **Site.css** file.

	Notice that the page inspector will prompt again for showing and refreshing.

1. In the Page Inspector browser, click once on the bar located below the address bar to reload the page.

 	![Moving the Log In link to the right](./images/Moving-the-Log-In-link-to-the-right.png?raw=true "Moving the Log In link to the right")
 
	_Moving the Log In link to the right_

1. Finally, you will change the header title. Instead of searching for the '**your logo here'** text in all the files, use the inspection mode to click the text and get to source code that generates it.

 	![Finding the site title](./images/Finding-the-site-title.png?raw=true "Finding the site title")
 
	_Finding the site title_

1. Now you are in **Site.Master**, replace the '**your logo here**' text with '**Photo Gallery**'. Save and update the Page Inspector browser.

 	![Photo Gallery page updated](./images/Photo-Gallery-page-updated.png?raw=true "Photo Gallery page updated")
 
	_Photo Gallery page updated_

1. Finally press **F5** to run the app the check out all the changes work as expected.

 


## Summary ##

By completing this Hands-On Lab, you have learnt how to use Page Inspector to preview your Web application without having to rebuild and run the Web site in a browser. In addition, you have learnt how to quickly find and fix bugs by accessing directly from the rendered output to the source code.













