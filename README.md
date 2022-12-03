# PhotoGrabber - A Reddit Mass Image Downloader Tool

## About ##
PhotoGrabber is a reddit image downloader that allows users to download posted images on subreddit or images posted by users. 
The tool works by providing the tool information such as:
  - If the user is trying to download from a subreddit or a reddit user
  - Provide user/subreddit name (must be exact name)
  - [WIP] Provide a specific folder to download the images
  - [OPTIONAL SELECTION] Provide the tool a sort by, according to reddit's standard post filters (Top, Hot, New, Rising, Controversial)
  
## Current UI ##

Initial Landing Page:

![start](https://user-images.githubusercontent.com/95333229/205420548-ca50b0ed-d581-4deb-8c94-547e328756a5.PNG)

Fill Information Type:
  - This requires if the user wants to search using a subreddit or a user
  - Provide exact name of user or subreddit
  - [OPTIONAL] Time Filter
  - Choose a file type (mp4 for videos and .gifs, .jpeg for images)
  - Provide an image limit (minimum 1, max 100 (will be increased in the future).
  
![fillInfo](https://user-images.githubusercontent.com/95333229/205420572-4b497800-11d5-43ea-bee0-7f81e51ba0e8.PNG)



Running Status:
  - Bar is Yellow when running
  - 
![whileRunning](https://user-images.githubusercontent.com/95333229/205420555-e86c2f63-7c2a-497e-9686-29582eb7a254.PNG)



Finished Status:
  - Bar is Green when finished downloading
  
![successfulOperation](https://user-images.githubusercontent.com/95333229/205420560-9f7c0782-2019-40b6-8474-ff316c243c08.PNG)



Failed Status:
  - Bar is Red when download has failed or stopped
  
![failed](https://user-images.githubusercontent.com/95333229/205420566-e0f244d4-1992-41ee-b112-8ec18e0ccbbf.PNG)


## WIP Features ##

The following features are a working in progress and will be implemented in the near future:
  - Compress download directory
  - Change directory location of folder (current saving to Desktop\FolderSpecified
  - Detect and Remove Duplicates
  - Save favourite subreddits and users for auto-fill
  - Save filter settings for auto fill
  - Build application along with uBlock-Origin.crx, unfortunately, users must place the ad-blocker and chrome driver files in the install directory of the application
  
## Important Disclaimers ##
  - I am in no way affiliated with Reddit or its companies
  - The application does not download directly from the Reddit official website due to closed source code.
  - Utilises https://www.popular.pics/ an alternative reddit media viewer (ctt: https://www.reddit.com/user/PopularPicsDev/ who is the main developer of this website,
    again not affiliated with them.)
  - THIS IS FOR EDUCATIONAL PURPOSES ONLY, PLEASE DONT SUE ME
  
## DOWNLOAD AT: [ReddiPhotoCrawler_beta1.1.zip](https://github.com/Syncline-blip/PhotoGrabber/files/10145533/ReddiPhotoCrawler_beta1.1.zip)

