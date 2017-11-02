komut satırına geç

!!! önce publish et

````


git push origin --delete gh-pages

biraz bekle


---------------------------------------
git add publish -f && git commit -m "ghpages-commit" 
git subtree push --prefix publish origin gh-pages



yukarı bitince çalıştır yoksa bir geçmişe gidersin
--------------------------------------------
git reset HEAD~ && rmdir /Q /S publish

````