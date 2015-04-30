----- Find my Colors! By: Ankit Sadana -----

----- Read Me -----

--- Instructions for running ---

1. 	Extract the zip anywhere
2. 	Open findMycolor.sln in Visual Studio 2013, build and run the solution.
		or 
	Run the findMyColor.exe from /bin/Debug folder. But don't move it before running, it will break the 
	relative paths set for the images (Check NOTE #1).

NOTE #1: Since the application runs from findMyColor/bin/Debug folder, the pictures have been given a relative path,
	"\\..\\..\\myResources\\imageName.png"
	So as long as you run the application from bin/Debug/ folder of the project, the images will load.

NOTE #2: Since during my previous assignment submission I noticed difference in size of objects/forms on different systems,
	I have saved snapshots of all four forms as they appear in my laptop right before submission in "gameSampleImages" folder. 
	Please excuse any visual elements that may appear different from them.

--- Deviations from StoryBoard Design ---

1. A new form, welcomeForm has been added (thank you for that idea Prof. Whitmer).
	This screen is a splash welcome screen with a welcome label and icon of the app before the game begins.

2. lblResponse's functionality has been replaced by picResponse.
	Instead of "Correct" and "Wrong", a smiley happy or sad face image is displayed.

3. A second level has been added to the mainGame form.
	This gives four new colors to colorString and let's user learn again before resuming the game.

4. ControlBox has been disabled in the learnWindow.
	This is to make sure user can't accidentally close it, since target user is kids.


--- Sources of images/cons used ---

1.	Smiley Image (Happy)	: http://images.all-free-download.com/images/graphiclarge/tango_face_smile_115986.jpg
2.	Smiley Image (Sad)		: http://images.all-free-download.com/images/graphiclarge/tango_face_sad_115987.jpg
3.	Application Icon		: http://i.utdstc.com/icons/120/7x7-best-color-strategy-game-android.png