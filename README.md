Home
====

Home Intelligence

by
[a simple git branching model](https://gist.github.com/jbenet/ee6c9ac48068889b0912 "by jbenet")

git checkout master  
git pull origin master  
git checkout -b my-new-feature  
 
EDIT 
 
git add .   
git commit -am "my changes"  

git fetch origin  
git rebase origin/master
git rebase origin/my-new-feature   

git push origin my-new-feature  

WHEN DONE  
   
git checkout master   
git pull origin master   
git merge --no-ff my-new-feature   

git tag 1.0.0-RC1


optional:  
feel free to rebase within your feature branch at will. ok to rebase after pushing if your team can handle it!

git rebase -i origin/master   