##BRANCHING MODEL

by
[a simple git branching model](https://gist.github.com/jbenet/ee6c9ac48068889b0912 "by jbenet")

- CLONE  
**git clone git@github.com:josemotta/Home.git**  

- START CHANGE    
**git checkout -b my-new-feature**

- EDIT    
**git add .**  
**git commit -am "my changes"**  

- GET UPDATE  
**git pull origin master**  
**git rebase master**  
git rebase origin/master  
git rebase origin/my-new-feature

- PUBLISH  
git push origin my-new-feature

- WHEN DONE  
**git checkout master**  
**git pull origin master**  
**git merge --no-ff my-new-feature**  
**git push origin master**  

- RELEASE  
**git tag -a v0.5.0 -m "Version 0.5.0 Stable"**  
**git push --tags**  
git push origin :refs/tags/v0.4.0-rc2 

- DELETE  
**git tag -d v0.4.2**  
**git push origin :v0.4.2**  



