#do not call this script directly, will be called on npm publish
cd ../
git add .
git commit -m 'patch'
git push origin master
cd ./robot-io-client
npm version patch