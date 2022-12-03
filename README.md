# PhotoGrabber - A reddit mass image downloader tool

## About ##
PhotoGrabber is a reddit image downloader that allows users to download posted images on subreddit or images posted by users. 
The tool works by providing the tool information such as:
  - If the user is trying to download from a subreddit or a reddit user
  - Provide user/subreddit name (must be exact name)
  - [WIP] Provide a specific folder to download the images
  - [OPTIONAL SELECTION] Provide the tool a sort by, according to reddit's standard post filters (Top, Hot, New, Rising, Controversial)
  
## Current UI ##

Initial Landing Page:

![alt text](https://imgur.com/KA8LG2T)

Fill Information Type:
  - This requires if the user wants to search using a subreddit or a user
  - Provide exact name of user or subreddit
  - [OPTIONAL] Time Filter
  - Choose a file type (mp4 for videos and .gifs, .jpeg for images)
  - Provide an image limit (minimum 1, max 100 (will be increased in the future).
  
![alt text](https://imgur.com/UL1Rv6e)

Running Status:
  - Bar is Yellow when running
 
![alt text](https://imgur.com/nydYL8f)

Finished Status:
  - Bar is Green when finished downloading
  
![alt text](https://imgur.com/CyE4zWU)


Failed Status:
  - Bar is Red when download has failed or stopped
  
![alt text](https://imgur.com/bJbrBbn)

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
  
## DOWNLOAD AT: [a link](https://github.com/Syncline-blip/PhotoGrabber/blob/master/ReddiPhotoCrawler_beta1.1.zip)
